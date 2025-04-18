
namespace allspice.Repositories;

public class FavoritesRepository
{
  public FavoritesRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;

  internal Favorite CreateFavoriteRecipe(Favorite favoriteData)
  {
    string sql = @"
    INSERT INTO favorites (recipe_id, account_id) 
    VALUES (@RecipeId, @AccountId);
    
    SELECT favorites.*, recipes.*, accounts.* FROM favorites
     INNER JOIN recipes ON recipes.id = favorites.recipe_id
     INNER JOIN accounts ON accounts.id = favorites.account_id
     WHERE favorites.id = LAST_INSERT_ID();
    
    ";

    Favorite favorite = _db.Query(sql, (FavoriteRecipe favorite, Recipe recipe, Account account) =>
    {
      favorite.Recipe = recipe;
      favorite.Creator = account;
      return favorite;
    }, favoriteData).SingleOrDefault();

    return favorite;
  }
}