using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Model;

namespace RazorPizza.Pages.Shared
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                imageTitle="Margerita",
                pizzaName="Margerita",
                basePrice = 2,
                tomatoSauce = true,
                cheese = true,
                finalPrice = 4
            },
            new PizzasModel() { imageTitle = "Bolognese", pizzaName = "Bolognese", basePrice = 2, beef = true, finalPrice = 5},
            new PizzasModel() { imageTitle = "Hawaiian", pizzaName ="Hawaiian", basePrice = 2, tomatoSauce = true, beef = true, finalPrice = 5},
            new PizzasModel() { imageTitle = "Carbonara", pizzaName ="Carbonara", basePrice = 2, tomatoSauce = true, beef = true, ham = true, finalPrice = 15},
            new PizzasModel() { imageTitle = "MeatFeast", pizzaName ="MeatFeast", basePrice = 2, tomatoSauce = true, beef = true, cheese = true, ham = true, finalPrice = 5},
            new PizzasModel() { imageTitle = "Mushroom", pizzaName ="Mushroom", basePrice = 2, tomatoSauce = true, beef = true, mushroom = true, cheese = true, finalPrice = 6},
            new PizzasModel() { imageTitle = "Seafood", pizzaName ="Seafood", basePrice = 2, tomatoSauce = true, cheese = true, tuna = true, finalPrice = 5},
            new PizzasModel() { imageTitle = "Vegetarian", pizzaName ="Vegetarian", basePrice = 2, tomatoSauce = true, cheese = true, mushroom = true, finalPrice = 12},
            new PizzasModel() { imageTitle = "Pepperoni", pizzaName = "Pepperoni", cheese = true, basePrice = 2, peperoni = true, tomatoSauce = true, finalPrice = 6}
            
        };
        public void OnGet()
        {
        }
    }
}
