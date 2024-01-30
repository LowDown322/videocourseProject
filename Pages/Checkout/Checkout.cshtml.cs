using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Model;

namespace RazorPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]

    public class CheckoutModel : PageModel
    {
        public string pizzaName { get; set; }
        public float pizzaPrice { get; set; }
        public string imageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(pizzaName)) 
            {
                pizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(imageTitle))
            {
                imageTitle = "Create";
            }
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.pizzaName = pizzaName;
            pizzaOrder.basePrice = pizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
