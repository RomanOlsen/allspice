


namespace allspice.Repositories;

public class FavoritesRepository
{
  public FavoritesRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;

  internal FavoriteRecipe CreateFavoriteRecipe(Favorite favoriteData)
  {
    string sql = @"
    INSERT INTO favorites (recipe_id, account_id) 
    VALUES (@RecipeId, @AccountId);
    
    SELECT favorites.*, recipes.*, accounts.* FROM favorites
     INNER JOIN recipes ON recipes.id = favorites.recipe_id
     INNER JOIN accounts ON recipes.creator_id = accounts.id
     WHERE favorites.id = LAST_INSERT_ID();
    
    ";

    FavoriteRecipe favorite = _db.Query(sql, (Favorite favorite, FavoriteRecipe favoriteRecipe, Account account) =>
    {
      favoriteRecipe.FavoriteId = favorite.Id;
      favoriteRecipe.Creator = account;

      // favorite = recipe;
      return favoriteRecipe;
    }, favoriteData).SingleOrDefault();

    return favorite;
  }

  internal Favorite GetFavoriteById(int favoriteFavoriteId)
  {
    string sql = @"
SELECT * FROM favorites WHERE favorites.id = @favoriteFavoriteId
;";
    Favorite favorite = _db.Query<Favorite>(sql, new { favoriteFavoriteId }).SingleOrDefault();
    return favorite;
  }

  internal void DeleteFavorite(int favoriteFavoriteId)
  {
    string sql = @"
DELETE FROM favorites WHERE favorites.id = @favoriteFavoriteId LIMIT 1
;";

    int rows = _db.Execute(sql, new { favoriteFavoriteId });
    if (rows != 1)
    {
      throw new Exception("No favorites were deleted (or many were!!!)");
    }
  }
}