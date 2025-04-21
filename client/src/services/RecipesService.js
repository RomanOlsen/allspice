import { logger } from "@/utils/Logger.js"
import { api } from "./AxiosService.js"

class RecipesService{
  async getAllRecipes() {
    const response = await api.get("api/recipes")
    logger.log(response.data)
  }
}
export const recipesService = new RecipesService()