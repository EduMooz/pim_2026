using Microsoft.AspNetCore.Mvc;
using PIM_2026.Models;

namespace PIM_2026.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmacao()
        {
         return View();   
        }

        public IActionResult Meusagendamentos()
        {
            return View();
        }

         [HttpPost] public IActionResult Salvaragendamento(Agendamento agendamento)
        {
            agendamento.Idcliente = 1;
            agendamento.Idprofissional = 1;
            agendamento.Status = "Pendente";


  
            return RedirectToAction("Confirmacao");
        }
    }
}

   
