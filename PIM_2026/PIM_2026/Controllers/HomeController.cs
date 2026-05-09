using Microsoft.AspNetCore.Mvc;
using PIM_2026.Models;
using System.Diagnostics;

namespace PIM_2026.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Verificar login - TESTE
        public IActionResult Verificarloginagendamento()
        {
            var usuario = HttpContext.Session.GetString("UsuarioNome");

            if (usuario != null)
            {
                // usuário logado
                return RedirectToAction("Index", "Agendamento");
            }

            // usuário NÃO logado
            return RedirectToAction("Login", "Conta");
        }

        public IActionResult Verificarloginmeusagendamentos()
        {
            var usuario = HttpContext.Session.GetString("UsuarioNome");

            if (usuario != null)
            {
                // usuário logado
                return RedirectToAction("Meusagendamentos", "Agendamento");
            }

            // usuário NÃO logado
            return RedirectToAction("Login", "Conta");
        }
    }
}
