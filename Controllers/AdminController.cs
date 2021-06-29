using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football_manager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Football_manager.Controllers
{
    public class AdminController : Controller
    {
        private IPlayerRepository repository;
        public AdminController(IPlayerRepository repo) {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Players);
        public ViewResult Edit(int Id) =>
                View(repository.Players
                .FirstOrDefault(p => p.Id == Id));
        [HttpPost]

        public IActionResult Edit(Player player)
        {
            if (ModelState.IsValid)
            {
                repository.SavePlayer(player);
                TempData["message"] = $" (product.Name) has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так co значениями данных
                return View(player);
            }
        }
    }
}
