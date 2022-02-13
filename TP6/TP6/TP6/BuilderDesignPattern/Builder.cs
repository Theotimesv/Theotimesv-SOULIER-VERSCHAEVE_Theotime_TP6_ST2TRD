using TP6.Properties;

namespace TP6
{
    public interface IBuilder
    {
        PizzaBuilder Reset();
        PizzaBuilder AddTomatoSauce();
        PizzaBuilder AddCreamSauce();
        PizzaBuilder AddCheese();
        PizzaBuilder AddMeat();
    }
}