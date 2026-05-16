using Microsoft.AspNetCore.Mvc;
using PIM_2026.Models;

namespace PIM_2026.Controllers
{
    public class AdminController : Controller
    {
        

        public IActionResult Dashboard()
        {
        
            ViewBag.TotalClientes = 0;

            ViewBag.ProximosAgendamentos = new List<Agendamento>();

            return View();
        }

        public IActionResult CancelarAgendamento(int id)
        {
            // var agendamento = linha do banco para ver o agendamentos(id);

            // if (agendamento != null)
            // {
            //     agendamento.Status = "Cancelado";
            //    salvar no banco;
            // }

            return RedirectToAction("Dashboard");
        }

        public IActionResult ConfirmarAgendamento(int id)
        {
            // var agendamento = linha de conexão com o banco para ver os agendamentos (id);

            // if (agendamento != null)
            // {
            //     agendamento.Status = "Confirmado";
            //     salvar no banco();
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

        public IActionResult Salvarservico()
        {
            return View();
        }

        public IActionResult Cadastrohorario()
        {
            return View();
        }

        public IActionResult Salvarhorario()
        {
            return View();
        }
    }
}