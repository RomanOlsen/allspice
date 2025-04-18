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
      // ingredientData.
      Ingredient ingredient = _ingredientsService.CreateIngredient(ingredientData, userInfo);
      return Ok(ingredient);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  // [HttpGet("/{recipeId}/ingredients")]
  // public ActionResult<List<Ingredient>> GetIngredientsForRecipe(int recipeId)
  // {
  //   try
  //   {
  //     List<Ingredient> ingredients = _ingredientsService.GetIngredientsForRecipe(recipeId);
  //     return Ok(ingredients);
  //   }
  //   catch (Exception e)
  //   {
  //     return BadRequest(e.Message);
  //   }
  // }
}