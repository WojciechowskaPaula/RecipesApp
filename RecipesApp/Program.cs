using System;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in RecipesApp!");
            Menu menu = new Menu();
            while (true)
            {
                Console.WriteLine("Check what you want to do:");
                menu.DisplayMenu();
                var userAnswer = menu.SaveMenuOption();
                menu.Execute(userAnswer);
            }
            
        }
        
    }
}
