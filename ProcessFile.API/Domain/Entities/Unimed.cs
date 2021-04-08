using System;

namespace ProcessFile.API.Domain.Entities
{
    public class Unimed : BaseEntity
    {
        public string TipoServico { get; set; }
        public DateTime DataConsumo { get; set; }
        public string ne { get; set; }
        public string CodigoDependenteSistema { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public decimal ValorDespesa { get; set; }
        public string Amb { get; set; }
        public string ControleUnimedLotacao { get; set; }
        public string ControleUnimedAcomodacao { get; set; }
        public string Pago { get; set; }

        public Process Process { get; set; }
    }
}
