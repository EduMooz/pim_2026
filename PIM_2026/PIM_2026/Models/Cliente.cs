namespace PIM_2026.Models
{
    public class Cliente : Usuario
    {
        public int Idcliente { get; set; }

        public string Telefone { get; set; }

        // POLIMORFISMO
        public override string TipoUsuario()
        {
            return "Cliente";
        }
    }
}