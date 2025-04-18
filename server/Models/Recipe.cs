namespace allspice.Models;

public class Recipe
{ // use upper pascal case
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public string Title { get; set; }
  public string Instructions { get; set; }
  public string Img { get; set; }
  public string Category { get; set; }
  public string CreatorId { get; set; }

  public Account Creator { get; set; }
}

public class FavoriteRecipe : Recipe
{
  // public Account Creator { get; set; } not needed since recipe inherits it
  // public Recipe Recipe { get; set; }


  public int FavoriteId { get; set; }
}
