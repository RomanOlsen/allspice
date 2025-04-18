

namespace allspice.Repositories;
public class IngredientsRepository
{
  public IngredientsRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;
  internal Ingredient CreateIngredient(Ingredient ingredientData)
  {
    string sql = @"
    INSERT INTO ingredients (name, quantity, recipe_id)
    VALUES (@Name, @Quantity, @RecipeId);
    
    SELECT * FROM ingredients WHERE ingredients.id = LAST_INSERT_ID();";

    Ingredient ingredient = _db.Query<Ingredient>(sql, ingredientData).SingleOrDefault();

    return ingredient;
  }

  internal List<Ingredient> GetIngredientsForRecipe(int recipeId)
  {
    string sql = @"
    SELECT * FROM ingredients WHERE recipe_id = @RecipeId;
    
    ";

    List<Ingredient> ingredients = _db.Query<Ingredient>(sql, new { recipeId }).ToList();
    return ingredients;
  }

  internal void DeleteIngredient(int ingredientId)
  {
    string sql = @"
    DELETE FROM ingredients WHERE id = @ingredientId LIMIT 1
    ";

    int rows = _db.Execute(sql, new { ingredientId });
    if (rows != 1)
    {
      throw new Exception("No rows were deleted (or many were!!!)");
    }
  }

  internal Ingredient GetIngredientById(int ingredientId)
  {
    string sql = @"
    SELECT * FROM ingredients WHERE id = @ingredientId
    ";

    Ingredient ingredient = _db.Query<Ingredient>(sql, new { ingredientId }).SingleOrDefault();
    return ingredient;
  }
}