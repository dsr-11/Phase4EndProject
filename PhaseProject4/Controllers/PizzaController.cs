using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PhaseProject4.Models;

namespace PhaseProject4.Controllers
{
    public class PizzaController : Controller
    {
        private static readonly PizzaBO context = new PizzaBO();
        private static List<Pizza> pizza_list = context.GetItems();

        public IActionResult Index()
        {
            return View(pizza_list);
        }
        public IActionResult Details(int id)
        {
            int index = pizza_list.FindIndex(x => x.pid == id);
            return View(pizza_list[index]);
        }
        public IActionResult checkout(int id)
        {
            int index = pizza_list.FindIndex(x => x.pid == id);
            ViewBag.price = pizza_list[index].price;
            return View();
        }
        public IActionResult success()
        {
            return View();
        }
    }
}
