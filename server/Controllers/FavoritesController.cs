namespace allspice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FavoritesController : ControllerBase
{
  public FavoritesController(Auth0Provider auth0Provider, FavoritesService favoritesService)
  {
    _auth0Provider = auth0Provider;
    _favoritesService = favoritesService;
  }

  private readonly Auth0Provider _auth0Provider;
  private readonly FavoritesService _favoritesService;

  [Authorize]
  [HttpPost]
  public async Task<ActionResult<FavoriteRecipe>> CreateFavoriteRecipe([FromBody] Favorite favoriteData) // int or Favorite type?
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      favoriteData.AccountId = userInfo.Id;
      FavoriteRecipe favorite = _favoritesService.CreateFavoriteRecipe(favoriteData);
      return Ok(favorite);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}