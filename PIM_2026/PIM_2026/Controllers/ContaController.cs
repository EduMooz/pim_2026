using PIM_2026.Models;
using Microsoft.AspNetCore.Mvc;

public class ContaController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Cadastro()
    {
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

    // 🔽 AQUI ENTRA O BANCO (deixe comentado por enquanto)

    // var usuario = _context.Usuarios
    //     .FirstOrDefault(u => u.Email == email);

    // Verifica se o usuário existe
    // if (usuario == null)
    // {
    //     ViewBag.Erro = "Email não encontrado.";
    //     return View();
    // }

    // Atualiza a senha (⚠️ depois usar hash!)
    // usuario.Senha = novaSenha;

    // _context.SaveChanges();

    // 🔼 FIM DO BANCO

    ViewBag.Sucesso = "Senha redefinida com sucesso!";
    return View();
}
}