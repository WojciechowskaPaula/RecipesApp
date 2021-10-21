using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    public class AllRecipes
    {
        private List<Recipe> Recipes { get; set; }

        public AllRecipes()
        {
            Recipes = new List<Recipe>();
        }
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }

        public Recipe AddRecipeInfo()
        {
            Recipe recipe = new Recipe();
            bool isANumber = false;
            int idInt = 0;
            while (isANumber == false)
            {
                Console.WriteLine("Enter recipe ID:");
                string id = Console.ReadLine();
                isANumber = int.TryParse(id, out idInt);
                if (isANumber == false)
                {
                    Console.WriteLine("The specified character is not a number. Please try again.");
                }
            }
            for (int i = 0; i < Recipes.Count; i++)
            {
                if (Recipes[i].Id == idInt)
                {
                    Console.WriteLine("The selected ID currently exists.");
                    return null;
                }
            }
            Console.WriteLine("Enter recipe Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter recipe Description:");
            var description = Console.ReadLine();
            recipe.Id = idInt;
            recipe.Name = name;
            recipe.Description = description;
            Console.Clear();
            return recipe;
        }

        public int RemoveRecipe()
        {
            Console.WriteLine("Enter recipe ID you want to remove:");
            string response = Console.ReadLine();
            Recipe recipeToRemove = null;
            int.TryParse(response, out int responseInt);
            foreach (var item in Recipes)
            {
                if (responseInt == item.Id)
                {
                    recipeToRemove = item;
                }
            }
            if (recipeToRemove != null)
            {
                Recipes.Remove(recipeToRemove);
                Console.WriteLine($"Recipe ID: {responseInt} succesfully removed.");
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
            Console.Clear();
            return responseInt;
        }

        public void DisplayRecipeDetails()
        {
            Console.WriteLine("Enter recipe ID you want to display:");
            string recipeId = Console.ReadLine();
            int.TryParse(recipeId, out int recipeIdInt);
            Recipe recipeToDisplay = null;
            foreach (var item in Recipes)
            {
                if (item.Id == recipeIdInt)
                {
                    recipeToDisplay = item;
                    break;
                }
            }
            if (recipeToDisplay != null)
            {
                Console.WriteLine($"Recipe details:\n ID: {recipeToDisplay.Id}\n Name: {recipeToDisplay.Name}\n " +
                $"Description: {recipeToDisplay.Description}");
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }
            Console.WriteLine("Press any key to try again.."); 
            Console.ReadKey();
            Console.Clear();
        }
    }
}
