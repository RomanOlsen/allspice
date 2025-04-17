
using System.Reflection.Metadata.Ecma335;
using MySqlConnector;

namespace allspice.Repositories;

public class RecipesRepository
{
  public RecipesRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;
  internal Recipe CreateRecipe(Recipe recipeData)
  {
    string sql = @"INSERT INTO recipes
    (title, instructions, img, category, creator_id)
    VALUES (@Title, @Instructions, @Img, @Category, @CreatorId);
    
    SELECT recipes.*, accounts.* 
    FROM recipes
    INNER JOIN accounts ON accounts.id = recipes.creator_id
    WHERE recipes.id = LAST_INSERT_ID();"; // i had ON accounts.id = recipe.creator_id without the s on recipes and it took me so long to figure that out

    Recipe recipe = _db.Query(sql, (Recipe recipe, Account account) =>
    {
      recipe.Creator = account;
      return recipe;
    }, recipeData).SingleOrDefault();
    return recipe;
  }

  internal List<Recipe> GetAllRecipes()
  {
    string sql = @"SELECT recipes.*, accounts.* FROM recipes
    INNER JOIN accounts ON accounts.id = recipes.creator_id;";
    List<Recipe> recipes = _db.Query(sql, (Recipe recipe, Account account) => { recipe.Creator = account; return recipe; }).ToList();
    return recipes;
  }

  internal Recipe GetRecipeById(int recipeId)
  {
    string sql = @"SELECT recipes.*, accounts.* FROM recipes
    INNER JOIN accounts ON accounts.id = recipes.creator_id
    WHERE recipes.id = @recipeId;";
    Recipe recipe = _db.Query(sql, (Recipe recipe, Account account) =>
    {
      recipe.Creator = account; return recipe;
    }, new { recipeId }).SingleOrDefault();

    return recipe;
  }
}