namespace allspice.Models;

public class Favorite
{
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public int RecipeId { get; set; }
  public string AccountId { get; set; }
}

// public class FavoriteRecipe : Favorite
// {
//   public Account Creator { get; set; }
//   public Recipe Recipe { get; set; }
// }
