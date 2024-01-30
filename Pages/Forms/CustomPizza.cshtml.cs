using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Pages.Shared;
using RazorPizza.Model;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizza { get; set; }
        public float pizzaPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            pizzaPrice = pizza.basePrice;
            if (pizza.tomatoSauce) pizzaPrice += 1;
            if (pizza.cheese) pizzaPrice += 1;
            if (pizza.ham) pizzaPrice += 10;
            if (pizza.tuna) pizzaPrice += 5;
            if (pizza.beef) pizzaPrice += 3;
            if (pizza.pineapple) pizzaPrice += 2;
            if (pizza.peperoni) pizzaPrice += 1;
            if (pizza.mushroom) pizzaPrice += 100;
            return RedirectToPage("/Checkout/Checkout", new { pizza.pizzaName, pizzaPrice   });
        }
    }
}
