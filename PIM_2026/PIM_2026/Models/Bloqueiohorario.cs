using System.Data;

namespace PIM_2026.Models
{
    public class Bloqueiohorario
    {
        public int Idbloqueio { get; set; }
        public int Idprossional { get; set;}
        public DateTime Data { get; set;}
        public TimeSpan Horario { get; set;}

    }   



}