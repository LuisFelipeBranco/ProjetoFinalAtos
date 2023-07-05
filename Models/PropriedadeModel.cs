using System.Runtime.CompilerServices;

namespace TeplanConsultoria.Models
{
    public class PropriedadeModel
    {
        public int ID { get; set; }
        public string NomePropriedade { get; set; }
        public double Area { get; set; }
        public string Cidade { get; set; }
        public string NomeProprietario { get; set; }
        public string Contato { get; set; }
        public DateTime dataServico { get; set; }
        public DateTime dataNota { get; set; }
        public DateTime dataPagamento { get; set; }
        public double Valor { get; set; }

    }
}