using System;
using TP6.IteratorDesignPattern;
using TP6.Properties;

namespace TP6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Question 2: Builder design pattern

            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            pizzaBuilder.createPizza();
            Pizza p1 = pizzaBuilder.AddCreamSauce().AddCheese().AddMeat().getPizza();
            pizzaBuilder.createPizza();
            Pizza p2 = pizzaBuilder.AddTomatoSauce().AddCheese().getPizza();

            p1.Display();
            p2.Display();

            //Question 4: Iterator design pattern
            ConcreteCollection library = new ConcreteCollection();
            
            library.AddBook(new Book("La Guerre et la Paix", 1));
            library.AddBook(new Book("Près de la mer", 2));
            library.AddBook(new Book("L'écume des jours", 3));
            library.AddBook(new Book("1994", 4));

            Iterator iterator = library.CreateIterator();

            for (Book book = iterator.Root(); !iterator.IsCompleted; book = iterator.Next())
            {
                Console.WriteLine("Book nb: " + book.BookId + ", Title: " + book.Title);
            }
        }
    }
}