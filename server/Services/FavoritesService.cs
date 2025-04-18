
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
}