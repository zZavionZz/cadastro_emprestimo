using Microsoft.AspNetCore.Mvc;

namespace cadastro_emprestimo.Controllers;
    public class EmprestimoLivros : Controller
    {
        public IActionResult Index()
        {
        return View();
        }
    }