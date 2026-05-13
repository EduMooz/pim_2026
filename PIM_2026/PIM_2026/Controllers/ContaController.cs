
using Microsoft.AspNetCore.Mvc;
using PIM_2026.Models;

namespace PIM_2026.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //Login do usuario
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            // login fixo da manicure
            if (email == "erikasantana@gmail.com" && senha == "erika123")
            {
                //Este código serve para salvar o login da erica
                HttpContext.Session.SetString("UsuarioNome", "Erika");
                HttpContext.Session.SetString("TipoUsuario", "Admin");
                return RedirectToAction("Dashboard", "Admin");
            }
            else if (email == "usuario@gmail.com" && senha == "user911")
            {
                HttpContext.Session.SetString("UsuarioNome", "Usuario");
                HttpContext.Session.SetString("TipoUsuario", "Usuario");
                return RedirectToAction("Index", "Home");
            }

            // MENSAGEM DE ERRO
            ViewBag.Erro = "Usuário não cadastrado ou senha incorreta";

            return View();
        }

        // GET → abre a tela
        [HttpGet]
        public IActionResult Esqueciasenha()
        {
            return View();
        }

        // POST → recebe o formulário
        [HttpPost]
        public IActionResult Esqueciasenha(string email, string novaSenha, string confirmarSenha)
        {
            // Valida se as senhas são iguais
            if (novaSenha != confirmarSenha)
            {
                ViewBag.Erro = "As senhas não coincidem.";
                return View();
            }

            // Valida se o email foi preenchido
            if (string.IsNullOrEmpty(email))
            {
                ViewBag.Erro = "Informe um email.";
                return View();
            }


            ViewBag.Sucesso = "Senha redefinida com sucesso!";
            return View();
        }

        //Função para que deslgoar o usuario
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }


    [HttpPost]
    public IActionResult Cadastro(Cliente cliente)
    {
        if (string.IsNullOrWhiteSpace(cliente.Nome) ||
            string.IsNullOrWhiteSpace(cliente.Email) ||
            string.IsNullOrWhiteSpace(cliente.Senha) ||
            string.IsNullOrWhiteSpace(cliente.Telefone))
        {
            ViewBag.Erro = "Preencha todos os campos.";
            return View("Login");
        }

        ViewBag.Sucesso = "Cadastro realizado com sucesso";

        return RedirectToAction("Confirmacaocadastro");
    }
   

        public IActionResult Confirmacaocadastro()
    {
        return View();
    }

    
    }
}
