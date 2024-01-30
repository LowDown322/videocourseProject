namespace RazorPizza.Model
{
    public class PizzasModel
    {
        public string imageTitle { get; set; }
        public string pizzaName { get; set; }
        public float basePrice { get; set; } = 2;
        public bool tomatoSauce { get; set; }
        public bool cheese { get; set; }
        public bool peperoni { get; set; }
        public bool mushroom { get; set; }
        public bool tuna { get; set; }
        public bool pineapple { get; set; }
        public bool ham { get; set; }
        public bool beef { get; set; }
        public float finalPrice { get; set; }
    }
}
