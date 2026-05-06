using Microsoft.AspNetCore.Mvc;
using PIM_2026.Models;

namespace PIM_2026.Controllers
{
    public class AdminController : Controller
    {
        // private readonly AppDbContext _context;

        public AdminController(/* AppDbContext context */)
        {
            // _context = context;
        }

        public IActionResult Dashboard()
        {
            // ViewBag.TotalClientes = _context.Clientes.Count();

            // ViewBag.AgendamentosHoje = _context.Agendamentos
            //     .Where(a => a.Data.Date == DateTime.Today)
            //     .ToList();

            // ViewBag.ProximosAgendamentos = _context.Agendamentos
            //     .Where(a => a.Data >= DateTime.Today)
            //     .OrderBy(a => a.Data)
            //     .ThenBy(a => a.Horario)
            //     .ToList();


            //Adicionei este codigo somente para ser possivel visualizar a pagina, quando tiver o banco de dados integrado precisa excluir - Carlos
            ViewBag.TotalClientes = 0;

            ViewBag.ProximosAgendamentos = new List<Agendamento>();

            return View();
        }

        public IActionResult CancelarAgendamento(int id)
        {
            // var agendamento = _context.Agendamentos.Find(id);

            // if (agendamento != null)
            // {
            //     agendamento.Status = "Cancelado";
            //     _context.SaveChanges();
            // }

            return RedirectToAction("Dashboard");
        }

        public IActionResult ConfirmarAgendamento(int id)
        {
            // var agendamento = _context.Agendamentos.Find(id);

            // if (agendamento != null)
            // {
            //     agendamento.Status = "Confirmado";
            //     _context.SaveChanges();
            // }

            return RedirectToAction("Dashboard");
        }

        public IActionResult Cadastroservico()
        {
            return View();
        }

        public IActionResult Horarios()
        {
            return View();
        }

        public IActionResult Listarservico()
        {
            return View();
        }

        public IActionResult Agenda()
        {
            return View();
        }
    }
}