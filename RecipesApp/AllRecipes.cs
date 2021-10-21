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
            Console.WriteLine("Enter recipe ID:");
            var id = Console.ReadLine();
            int.TryParse(id, out int idInt);
            Console.WriteLine("Enter recipe Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter recipe Description:");
            var description = Console.ReadLine();
            Recipe recipe = new Recipe();
            recipe.Id = idInt;
            recipe.Name = name;
            recipe.Description = description;
            return recipe;
        }

        public int RemoveRecipe()
        {
            Console.WriteLine("Enter recipe ID you want to remove:");
            string response = Console.ReadLine();
            int.TryParse(response, out int responseInt);
            foreach (var item in Recipes)
            {
                if(responseInt == item.Id)
                {
                    Recipes.Remove(item);
                }
            }
            Console.WriteLine($"Recipe ID: {responseInt} succesfully removed");
            return responseInt;
            
        }

    }


}
