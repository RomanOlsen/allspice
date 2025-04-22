import { logger } from "@/utils/Logger.js"
import { api } from "./AxiosService.js"
import { Recipe } from "@/models/Recipe.js"
import { AppState } from "@/AppState.js"

class RecipesService{
  async getRecipeResults(typeNumber) {
    if (typeNumber == 1) {
      await this.getAllRecipes();
      return;
    }
    if (typeNumber == 2) {
      await this.getMyRecipes() // favorited recipes that YOU made. Or just any recipe you made? there is no postman test i can find for this exact.
      return;
    }
    if (typeNumber == 3) {
      await this.getFavoriteRecipes(); // gets ALL favorited recipes
      return;
    }
    return;
  }

  async getAllRecipes() {
    const response = await api.get("api/recipes")
    this.mapAndAddToAppState(response)
  }
  async getMyRecipes() {
    const response = await api.get("account/recipes")
    this.mapAndAddToAppState(response)
  }
  async getFavoriteRecipes() {
        const response = await api.get("account/favorites")
        this.mapAndAddToAppState(response)
  }
////////////////////////////////////////////////////////////////////////
  mapAndAddToAppState(response){
    logger.log(response.data)
    const recipes = response.data.map(pojo => new Recipe(pojo))
    AppState.recipes = recipes
  }
}
export const recipesService = new RecipesService()