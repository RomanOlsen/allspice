
namespace allspice.Services;

public class FavoritesService
{
  public FavoritesService(FavoritesRepository favoritesRepository)
  {
    _repository = favoritesRepository;
  }
  private readonly FavoritesRepository _repository;
  internal Favorite CreateFavoriteRecipe(Favorite favoriteData)
  {
    Favorite favorite = _repository.CreateFavoriteRecipe(favoriteData);
    return favorite;
  }
}