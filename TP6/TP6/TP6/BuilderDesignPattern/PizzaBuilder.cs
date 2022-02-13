namespace TP6.Properties
{
    
    public class PizzaBuilder : IBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder Reset()
        {
            _pizza.Ingredients().Clear();
            return this;
        }
        public Pizza getPizza()
        {
            return _pizza;
        }
        public void createPizza()
        {
            _pizza = new Pizza();
        }

        public PizzaBuilder AddTomatoSauce()
        {
            _pizza.Ingredients().Add("Base Tomato");
            return this;
        }
        
        public PizzaBuilder AddCreamSauce()
        {
            _pizza.Ingredients().Add("Base Cream");
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            _pizza.Ingredients().Add("Cheese");
            return this;
        }

        public PizzaBuilder AddMeat()
        {
            _pizza.Ingredients().Add("Meat");
            return this;
        }
    }
}