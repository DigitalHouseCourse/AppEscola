using AppEscola.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppEscola.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<PersonModel>Alunos = new List<PersonModel>();

            Alunos.Add(new PersonModel() { id = 1, nome = "William", sobrenome = "Sant-Anna", status = "Reprovado"});
            Alunos.Add(new PersonModel() { id = 2, nome = "Thiago", sobrenome = "Machado", status = "Aprovado" });
            Alunos.Add(new PersonModel() { id = 3, nome = "Rodrigo", sobrenome = "Braga", status = "Aprovado" });
            Alunos.Add(new PersonModel() { id = 4, nome = "Caroline", sobrenome = "da Silva", status = "Recuperação" });
            return View(Alunos);

        }

        public IActionResult William()
        {
                List<Notas> notas = new List<Notas>();

                notas.Add(new Notas()
                {
                    id = 1,
                    materia = "Português",
                    nota1 = 5,
                    nota2 = 6.5,
                    nota3 = 6.5,
                    nota4 = 0,
                    status = "Reprovado"

                });;

                notas.Add(new Notas()
                {
                    id = 2,
                    materia = "Matemática",
                    nota1 = 10,
                    nota2 = 8,
                    nota3 = 8,
                    nota4 = 8,
                    status = "Aprovado"

                });

                notas.Add(new Notas()
                {
                    id = 3,
                    materia = "Ciências",
                    nota1 = 6,
                    nota2 = 7.5,
                    nota3 = 8,
                    nota4 = 8,
                    status = "Aprovado"

                });

                notas.Add(new Notas()
                {
                    id = 4,
                    materia = "História",
                    nota1 = 8,
                    nota2 = 9,
                    nota3 = 10,
                    nota4 = 7.5,
                    status = "Aprovado"

                });

            return View(notas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}