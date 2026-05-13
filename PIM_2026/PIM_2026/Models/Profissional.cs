namespace PIM_2026.Models
{
    public class Profissional : Usuario
    {
        public int Idprofissional { get; set; }

        // POLIMORFISMO
        public override string TipoUsuario()
        {
            return "Profissional";
        }
    }
}