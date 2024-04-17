using Microsoft.AspNetCore.Mvc;
using Pim3.Data;
using Pim3.Models;

namespace Pim3.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private AplicationDbContext _db
            ;
        public EmprestimoController(AplicationDbContext db) {
            _db = db ;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos; 
            return View(emprestimos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimos    )
        {
            if (ModelState.IsValid)
            {
             _db.Emprestimos.Add(emprestimos);
             _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();

        }

    }
}
