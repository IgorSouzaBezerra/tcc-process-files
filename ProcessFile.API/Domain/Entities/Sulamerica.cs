using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Domain.Entities
{
    public class Sulamerica : BaseEntity
    {
        public string Sequencia { get; set; }
        public string Carteirinha { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataRegistro { get; set; }
        public string Mais { get; set; }
        public decimal Valor { get; set; }
        public string CodigoAleatorio { get; set; }
        public string Nascimento { get; set; }
        public string CNPJ { get; set; }
        public string NomeColaborador { get; set; }
        public string NE { get; set; }

        public Process Process { get; set; }
    }
}
