


namespace allspice.Services;

public class RecipesService
{
  public RecipesService(RecipesRepository recipesRepository)
  {
    _recipesRepository = recipesRepository;
  }
  private readonly RecipesRepository _recipesRepository;
  internal Recipe CreateRecipe(Recipe recipeData)
  {
    Recipe recipe = _recipesRepository.CreateRecipe(recipeData);
    return recipe;
  }

  internal List<Recipe> GetAllRecipes()
  {
    List<Recipe> recipes = _recipesRepository.GetAllRecipes();
    return recipes;
  }

  internal Recipe GetRecipeById(int recipeId)
  {
    Recipe recipe = _recipesRepository.GetRecipeById(recipeId);
    return recipe;
  }

  internal Recipe UpdateRecipe(Recipe recipeData, int recipeId, Account userInfo)
  {
    Recipe foundRecipe = GetRecipeById(recipeId);
    if (foundRecipe is null)
    {
      throw new Exception("We couldnt find a recipe with that id, so theres no way to update it");
    }
    if (foundRecipe.CreatorId != userInfo.Id)
    {
      throw new Exception("403 forbidden error. You cannot edit someone else's recipe");
    }
    Recipe recipe = _recipesRepository.UpdateRecipe(recipeData);
    return recipe;
  }
}