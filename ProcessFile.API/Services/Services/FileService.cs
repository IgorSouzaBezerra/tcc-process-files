using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class FileService : IFileService
    {
        private readonly IColumnControlRepository _columnControlRepository;
        private readonly ISulamericaRepository _sulamericaRepository;
        private readonly IUnimedRepository _unimedRepository;
        private readonly IProcessRepository _processRepository;

        private List<dynamic> list = new List<dynamic>();

        public FileService(IColumnControlRepository columnControlRepository, ISulamericaRepository sulamericaRepository, IUnimedRepository unimedRepository, IProcessRepository processRepository)
        {
            _columnControlRepository = columnControlRepository;
            _sulamericaRepository = sulamericaRepository;
            _unimedRepository = unimedRepository;
            _processRepository = processRepository;
        }

        public async Task<List<dynamic>> ReadFile(string filename, string subject)
        {
            string company = "";
            List<string> entityIndex = new List<string>();

            if (subject.ToUpper().Contains("SULAMERICA"))
            {
                company = "Sulamerica";
            }
            else if (subject.ToUpper().Contains("UNIMED"))
            {
                company = "Unimed";
            }

            List<ColumnControl> control = await _columnControlRepository.FindByCompany(company);

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Files\" + filename);

            Process process = await _processRepository.CreateProcess(company);

            string field = "";

            foreach (string line in lines)
            {
                foreach (ColumnControl item in control)
                {
                    for (int i = item.Start; i <= item.End; i++)
                    {
                        if (field.Length != item.Size)
                        {
                            field += line[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    entityIndex.Add(field);
                    field = "";
                }

                if (subject.ToUpper().Contains("SULAMERICA"))
                {
                    Console.WriteLine("Valor Inicial: " + entityIndex[6]);

                    Sulamerica obj = new Sulamerica
                    {
                        Sequencia = entityIndex[0],
                        Carteirinha = entityIndex[1],
                        Nome = entityIndex[2],
                        CPF = entityIndex[3],
                        DataRegistro = entityIndex[4],
                        Mais = entityIndex[5],
                        Valor = InsertComma(entityIndex[6]),
                        CodigoAleatorio = entityIndex[7],
                        Nascimento = entityIndex[8],
                        CNPJ = entityIndex[9],
                        NomeColaborador = entityIndex[10],
                        NE = entityIndex[11],
                        Process = process
                    };

                    list.Add(obj);

                    await _sulamericaRepository.Create(obj);
                    entityIndex.Clear();
                }
                else if (subject.ToUpper().Contains("UNIMED"))
                {
                    Unimed obj = new Unimed
                    {
                        TipoServico = entityIndex[0],
                        DataConsumo = DateTime.ParseExact(entityIndex[1], "ddMMyyyy", CultureInfo.CreateSpecificCulture("pt-BR")),
                        ne = entityIndex[2],
                        CodigoDependenteSistema = entityIndex[3],
                        Nome = entityIndex[4],
                        Crm = entityIndex[5],
                        ValorDespesa = decimal.Parse(entityIndex[6]),
                        Amb = entityIndex[7],
                        ControleUnimedLotacao = entityIndex[8],
                        ControleUnimedAcomodacao = entityIndex[9],
                        Pago = entityIndex[10],
                        Process = process
                    };

                    list.Add(obj);

                    await _unimedRepository.Create(obj);
                    entityIndex.Clear();
                }

            }
            
            return list;
        }

        public decimal InsertComma(string str)
        {
            int size = str.Length;
            string strFormat = str.Insert(size - 2, ".");
            Console.WriteLine("strFormat: " + strFormat);
            decimal strFormatDecimal = decimal.Parse(strFormat);
            Console.WriteLine("strFormatDecimal: " + strFormatDecimal);
            return strFormatDecimal;
        }
    }
}
