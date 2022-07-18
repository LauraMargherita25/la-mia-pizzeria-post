using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //List<Pizza> pizzaList = new List<Pizza>();
            //pizzaList.Add(new Pizza(1, "Margherita Static", "lorem ipsum", "img/margherita.jpg", 5));
            //pizzaList.Add(new Pizza(2, "Capricciosa Static", "lorem ipsum", "img/margherita.jpg", 5));
            //pizzaList.Add(new Pizza(3, "Marinara Static", "lorem ipsum", "img/margherita.jpg", 5));

            PizzeriaContext context = new PizzeriaContext();
            return View(context.Pizze.ToList());
        }

        public IActionResult Detail(int id)
        {
            //using (PizzeriaContext context = new PizzeriaContext())
            //{
            //    Pizza thisPizza = context.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

            //    return View(thisPizza);

            //}
            PizzeriaContext context = new PizzeriaContext();
            Pizza pizza = context.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();
            return View(pizza);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

