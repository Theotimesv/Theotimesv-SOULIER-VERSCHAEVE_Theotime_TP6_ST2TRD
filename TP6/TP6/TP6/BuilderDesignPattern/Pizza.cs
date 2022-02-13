using System;
using System.Collections.Generic;

namespace TP6.Properties
{
    public class Pizza
    {
        private List<string> _ingredients;

        public Pizza(List<string> ingredients)
        {
            _ingredients = ingredients;
        }

        public List<string> Ingredients()
        {
            return _ingredients;
        }

        public Pizza()
        {
            _ingredients = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine("Pizza ingredients:");
            foreach (string ing in _ingredients)
            {
                Console.Write(ing + " ");
            }
            Console.WriteLine("\n");
        }
    }
}