using System;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in RecipesApp!");
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Menu menu = new Menu();
            while (true)
            {
                Console.WriteLine("Check what you want to do:");
                menu.DisplayMenu();
                var userAnswer = menu.SaveMenuOption();
                Console.Clear();
                menu.Execute(userAnswer);
            }
            
        }
        
    }
}
