using RecipesApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    public class Menu
    {
        private List<string> menuOptions;

        private AllRecipes allRecipes;

        public Menu()
        {
            menuOptions = new List<string>() { "1. Add new recipe", "2. Remove recipe", "3. Display recipe details", 
                "0. Exit" };
            allRecipes = new AllRecipes();
        }
        public void DisplayMenu()
        {
            foreach (var item in menuOptions)
            {
                Console.WriteLine(item);
            }
        }
        public int SaveMenuOption()
        {
            string answer = Console.ReadLine();
            int intAnswer = 0;
            
            for (int i = 0; i < answer.Length; i++)
            {
                if (!char.IsDigit(answer[i]))
                {
                    Console.WriteLine("Please choose one of the available options.");
                    Console.WriteLine("Press any key to try again..");
                    Console.ReadKey();
                    return -1;
                }
                else
                {
                    int.TryParse(answer, out intAnswer);
                }
            }
            return intAnswer;
        }

        public void Execute(int option)
        {
            switch (option)
            {
                case 1:
                    var newRecipe = allRecipes.AddRecipeInfo();
                    allRecipes.AddRecipe(newRecipe);
                    break;
                case 2:
                    var removeId = allRecipes.RemoveRecipe();
                    break;
                case 3:
                    allRecipes.DisplayRecipeDetails();
                    break;
                case 0:
                    AppHelper.ExitApp();
                    break;
                default:
                    Console.WriteLine("Your action does not exist");
                    Console.Clear();
                    break;
            }
            
        }
    }
}
