using System.Data;

namespace PIM_2026.Models
{
    public class Agendamento
    {
        public int Idcliente { get; set; }
        public int Idprofissional { get; set; }
        public int Idagendamento { get; set; }
        public int Idservico { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Horario { get; set; }
        public string Status { get; set; } = "Pendente";
    }

    
}


