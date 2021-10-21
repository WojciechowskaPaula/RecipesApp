using System;

namespace RecipesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in RecipesApp!");
            while (true)
            {
                Console.WriteLine("Check what you want to do:");

                Menu menu = new Menu();
                menu.DisplayMenu();
                var userAnswer = menu.SaveMenuOption();
                menu.Execute(userAnswer);
            }
            
        }
        
    }
}
