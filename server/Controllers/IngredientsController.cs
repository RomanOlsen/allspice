namespace allspice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientsController : ControllerBase
{
  public IngredientsController(Auth0Provider auth0Provider, IngredientsService ingredientsService)
  {
    _auth0Provider = auth0Provider;
    _ingredientsService = ingredientsService;
  }
  private readonly Auth0Provider _auth0Provider;
  private readonly IngredientsService _ingredientsService;

  [Authorize]
  [HttpPost]
  public async Task<ActionResult<Ingredient>> CreateIngredient([FromBody] Ingredient ingredientData)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      Ingredient ingredient = _ingredientsService.CreateIngredient(ingredientData, userInfo);
      return Ok(ingredient);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [Authorize]
  [HttpDelete("{ingredientId}")]
  public async Task<ActionResult<Recipe>> DeleteIngredient(int ingredientId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      string message = _ingredientsService.DeleteIngredient(ingredientId, userInfo);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}