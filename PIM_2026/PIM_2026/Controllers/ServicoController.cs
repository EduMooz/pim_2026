using Microsoft.AspNetCore.Mvc;
namespace PIM_2026.Controllers
{
    public class ServicoController : Controller
    {
        // private readonly AppDbContext _context;

        public ServicoController(/* AppDbContext context */)
        {
            // _context = context;
        }

        // Lista todos os serviços
        public IActionResult Listaservicos()
        {
            // Busca os serviços no banco
            // var servicos = _context.Servicos.ToList();

            // Enquanto não tem banco, pode retornar vazio ou só a view
            return View(/* servicos */);
        }

        // Abre a tela de cadastro
        public IActionResult Cadastroservico()
        {
            return View();
        }

        // Recebe os dados do formulário
        [HttpPost]
        public IActionResult Salvarservico(/* Servico servico */)
        {
            // Salva no banco
            // _context.Servicos.Add(servico);
            // _context.SaveChanges();

            // Redireciona pra lista depois de salvar
            return RedirectToAction("Listaservicos");
        }
    }
}