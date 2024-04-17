using Microsoft.AspNetCore.Mvc;
using ProjetoADV.Data;
using ProjetoADV.Models;

namespace ProjetoADV.Controllers
{
    public class ContatoController : Controller
    {
        private ApplicationDbContext _context;
        public ContatoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var usuarios = _context.Usuario.ToList();
            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ConfirmDeletar(int id)
        {
            var usuario = _context.Usuario.Find(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Deletar(int id)
        {
            var usuario = _context.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
