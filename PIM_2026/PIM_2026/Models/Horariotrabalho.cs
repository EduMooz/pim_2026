using System.Data;

namespace PIM_2026.Models
{
  public class Horariotrabalho
  {
    public int Idhorario { get; set; }
    public int Idprofissional { get; set; }
    public string Diasemana { get; set; }  //não seria melhor data ao inves de Diasemana?
    public TimeSpan Horainicio {get; set; }
    public TimeSpan Horafim {get; set; }


  }



    
}