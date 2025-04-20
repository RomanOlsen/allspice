

namespace allspice.Services;

public class FavoritesService
{
  public FavoritesService(FavoritesRepository favoritesRepository)
  {
    _repository = favoritesRepository;
  }
  private readonly FavoritesRepository _repository;
  internal FavoriteRecipe CreateFavoriteRecipe(Favorite favoriteData)
  {
    FavoriteRecipe favorite = _repository.CreateFavoriteRecipe(favoriteData);
    return favorite;
  }

  internal string DeleteFavorite(int favoriteFavoriteId, Account userInfo)
  {
  
Favorite favorite = _repository.GetFavoriteById(favoriteFavoriteId);
if (favorite.AccountId != userInfo.Id)
{
  throw new Exception("You cannot delete someone elses favorite");
}

_repository.DeleteFavorite(favoriteFavoriteId);

return "This is no longer a favorite";

  }
}