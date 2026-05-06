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



//Não seria melhor juntar este model com o Horariotrabalho? Pois no cshtml não é possivel puxar de dois models, e como os dois se complementam, acho que seria melhor