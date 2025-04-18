
namespace allspice.Services;

public class IngredientsService
{
  private readonly IngredientsRepository _repository;
  public IngredientsService(IngredientsRepository ingredientsRepository)
  {
    _repository = ingredientsRepository;
  }

  internal Ingredient CreateIngredient(Ingredient ingredientData, Account userInfo)
  {
    Ingredient ingredient = _repository.CreateIngredient(ingredientData);
    return ingredient;
  }

  internal List<Ingredient> GetIngredientsForRecipe(int recipeId)
  {
    List<Ingredient> ingredients = _repository.GetIngredientsForRecipe(recipeId);
    return ingredients;
  }
}