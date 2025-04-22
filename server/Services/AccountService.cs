namespace allspice.Services;

public class AccountService
{
  private readonly AccountsRepository _repo;

  public AccountService(AccountsRepository repo)
  {
    _repo = repo;
  }

  private Account GetAccount(string accountId)
  {
    Account account = _repo.GetById(accountId);
    if (account == null)
    {
      throw new Exception("Invalid Account Id");
    }
    return account;
  }

  internal Account GetOrCreateAccount(Account userInfo)
  {
    Account account = _repo.GetById(userInfo.Id);
    if (account == null)
    {
      return _repo.Create(userInfo);
    }
    return account;
  }

  internal Account Edit(Account editData, string accountId)
  {
    Account original = GetAccount(accountId);
    original.Name = editData.Name ?? editData.Name;
    original.Picture = editData.Picture ?? editData.Picture;
    return _repo.Edit(original);
  }

  internal List<FavoriteRecipe> GetAccountFavoriteRecipes(string userInfoId)
  {
    List<FavoriteRecipe> favorites = _repo.GetAccountFavoriteRecipes(userInfoId);
    return favorites;
  }

  internal List<Recipe> GetMyRecipes(string userInfoId)
  {
    List<Recipe> recipes = _repo.GetMyRecipes(userInfoId);
    return recipes;
  }
}
