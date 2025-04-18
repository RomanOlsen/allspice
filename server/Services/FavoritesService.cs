
namespace allspice.Services;

public class FavoritesService
{
  public FavoritesService(FavoritesRepository favoritesRepository)
  {
    _repository = favoritesRepository;
  }
  private readonly FavoritesRepository _repository;
  internal Favorite CreateFavoriteRecipe(int recipeId)
  {
    Favorite favorite = _repository.CreateFavoriteRecipe(recipeId);
    return favorite;
  }
}