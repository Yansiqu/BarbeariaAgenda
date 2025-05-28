using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BarbeariaAgenda.Models;

namespace BarbeariaAgenda.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly AppDbContext _context;

        public AgendamentosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var agendamentos = _context.Agendamentos.Include(a => a.Barbeiro).ToList();
            return View(agendamentos);
        }

        public IActionResult Create()
        {
            ViewBag.Barbeiros = _context.Barbeiros.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Agendamentos.Add(agendamento);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Barbeiros = _context.Barbeiros.ToList();
            return View(agendamento);
        }
    }
}
