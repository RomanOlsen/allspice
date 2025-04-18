


namespace allspice.Services;

public class RecipesService
{
  public RecipesService(RecipesRepository recipesRepository)
  {
    _repository = recipesRepository;
  }
  private readonly RecipesRepository _repository;
  internal Recipe CreateRecipe(Recipe recipeData)
  {
    Recipe recipe = _repository.CreateRecipe(recipeData);
    return recipe;
  }

  internal List<Recipe> GetAllRecipes()
  {
    List<Recipe> recipes = _repository.GetAllRecipes();
    return recipes;
  }

  internal Recipe GetRecipeById(int recipeId)
  {
    Recipe recipe = _repository.GetRecipeById(recipeId);

    if (recipe is null)
    {
      throw new Exception("We couldnt find a recipe with that id, so theres no way to update it");
    }

    return recipe;
  }

  internal void UpdateRecipe(Recipe recipeData, int recipeId, Account userInfo)
  {
    Recipe foundRecipe = GetRecipeById(recipeId);

    if (foundRecipe.CreatorId != userInfo.Id)
    {
      throw new Exception("403 forbidden error. You cannot edit someone else's recipe");
    }

    foundRecipe.Title = recipeData.Title ?? foundRecipe.Title;
    foundRecipe.Instructions = recipeData.Instructions ?? foundRecipe.Instructions;
    foundRecipe.Img = recipeData.Img ?? foundRecipe.Img;
    foundRecipe.Category = recipeData.Category ?? foundRecipe.Category;



    _repository.UpdateRecipe(foundRecipe);
    // return recipe;
  }

  internal void DeleteRecipe(int recipeId, Account userInfo)
  {
    Recipe foundRecipe = GetRecipeById(recipeId);

    if (foundRecipe.CreatorId != userInfo.Id)
    {
      throw new Exception("403 forbidden error. You cannot delete someone else's recipe");
    }
    _repository.DeleteRecipe(recipeId);
  }
}