

namespace allspice.Repositories;

public class AccountsRepository
{
  private readonly IDbConnection _db;

  public AccountsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Account GetByEmail(string userEmail)
  {
    string sql = "SELECT * FROM accounts WHERE email = @userEmail";
    return _db.QueryFirstOrDefault<Account>(sql, new { userEmail });
  }

  internal Account GetById(string id)
  {
    string sql = "SELECT * FROM accounts WHERE id = @id";
    return _db.QueryFirstOrDefault<Account>(sql, new { id });
  }

  internal Account Create(Account newAccount)
  {
    string sql = @"
            INSERT INTO accounts
              (name, picture, email, id)
            VALUES
              (@Name, @Picture, @Email, @Id)";
    _db.Execute(sql, newAccount);
    return newAccount;
  }

  internal Account Edit(Account update)
  {
    string sql = @"
            UPDATE accounts
            SET 
              name = @Name,
              picture = @Picture
            WHERE id = @Id;";
    _db.Execute(sql, update);
    return update;
  }

  internal List<FavoriteRecipe> GetAccountFavoriteRecipes(string userInfoId)
  {
    string sql = @$"
    SELECT 
    favorites.*,
     recipes.*, 
     accounts.* FROM favorites
     INNER JOIN recipes ON recipes.id = favorites.recipe_id
     INNER JOIN accounts ON recipes.creator_id = accounts.id
     WHERE favorites.account_id = @userInfoId
;";

    List<FavoriteRecipe> favorites = _db.Query(sql, (Favorite favorite, FavoriteRecipe favoriteRecipe, Account account) =>
    {
      favoriteRecipe.FavoriteId = favorite.Id;
      favoriteRecipe.Creator = account;

      return favoriteRecipe;
    }, new { userInfoId }).ToList();
    return favorites;
  }

  internal List<Recipe> GetMyRecipes(string userInfoId)
  {
    string sql = @"
    SELECT 
    recipes.*, 
    accounts.* 
    FROM recipes
    INNER JOIN accounts ON accounts.id = recipes.creator_id 
    WHERE recipes.creator_id = @userInfoId;";
    List<Recipe> recipes = _db.Query(sql, (Recipe recipe, Account account) => { recipe.Creator = account; return recipe; }, new { userInfoId }).ToList();
    return recipes;
  }
}

