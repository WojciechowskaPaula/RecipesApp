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
           
            Console.WriteLine("Enter recipe ID:");
            string id = Console.ReadLine();
            int.TryParse(id, out int idInt);

            for (int i = 0; i < Recipes.Count; i++)
            {
                if (Recipes[i].Id == idInt)
                {
                    Console.WriteLine("The selected ID currently exists");
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
                Console.WriteLine($"Recipe ID: {responseInt} succesfully removed");
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }


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
                Console.WriteLine($"Recipe details:\n ID:{recipeToDisplay.Id}\n Name:{recipeToDisplay.Name}\n " +
                $"Description:{recipeToDisplay.Description}");
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }

        }

    }


}
