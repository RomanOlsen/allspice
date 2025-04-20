namespace allspice.Services;

public class IngredientsService
{
  private readonly IngredientsRepository _repository;
  private readonly RecipesService _recipesService;
  public IngredientsService(IngredientsRepository ingredientsRepository, RecipesService recipesService)
  {
    _repository = ingredientsRepository;
    _recipesService = recipesService;
  }

  internal Ingredient CreateIngredient(Ingredient ingredientData, Account userInfo)
  {
    GetRecipeAndCheckOwnership(ingredientData, userInfo);
    Ingredient ingredient = _repository.CreateIngredient(ingredientData);
    return ingredient;
  }

  internal string DeleteIngredient(int ingredientId, Account userInfo)
  {
    Ingredient ingredient = _repository.GetIngredientById(ingredientId);
    GetRecipeAndCheckOwnership(ingredient, userInfo);
    _repository.DeleteIngredient(ingredientId);
    return "It was deleted";
  }

  internal List<Ingredient> GetIngredientsForRecipe(int recipeId)
  {
    List<Ingredient> ingredients = _repository.GetIngredientsForRecipe(recipeId);
    return ingredients;
  }
  internal void GetRecipeAndCheckOwnership(Ingredient ingredient, Account userInfo)
  {
    Recipe recipe = _recipesService.GetRecipeById(ingredient.RecipeId);
    if (userInfo.Id != recipe.CreatorId)
    {
      throw new Exception("You are forbidden! Thats not your recipe, so you cannot add or delete any ingredients");
    }
  }
}