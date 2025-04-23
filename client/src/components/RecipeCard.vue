<script setup>
import { Recipe } from '@/models/Recipe.js';
import RecipeDetailsModal from './RecipeDetailsModal.vue';
import { Pop } from '@/utils/Pop.js';
import { logger } from '@/utils/Logger.js';
import { recipesService } from '@/services/RecipesService.js';

defineProps({
  recipeProp: { type: Recipe, required: true }
})

async function setActiveRecipe(recipeId) {
  try {
    await recipesService.setActiveRecipe(recipeId)
  }
  catch (error) {
    Pop.error(error, 'couldnt set active recipe');
    logger.log('could not set active recipe', error)

  }
}
</script>


<!-- <div>{{ recipeProp.title }}</div> -->
<template>
  <div class="position-relative">

    <div @click="setActiveRecipe(recipeProp.id)" class="card mt-4 shadow text-light" :style="{ backgroundImage: `url(${recipeProp.img})` }"
      data-bs-toggle="modal" data-bs-target="#RecipeDetailsModal" type="button">
      <div class="card-header d-flex justify-content-between align-items-center"><span
          class="recipe-category-bg rounded-pill px-3">{{ recipeProp.category }}</span>
      </div>
      <div class="card-body"></div>
      <div class="card-footer fs-5 fw-bold">{{ recipeProp.title }}</div>
    </div>
    <button class="btn recipe-category-bg favorite-button">
      <span v-if="recipeProp.favoriteId" class="mdi mdi-heart text-danger" title="click to unfavorite"></span>
      <span v-else class="mdi mdi-heart text-light" title="click to favorite"></span>
    </button>
  </div>

</template>


<style lang="scss" scoped>
.card {
  background-image: url();
  border: none;
  background-size: cover;
  background-position: center;
  aspect-ratio: 1/1;
}

// .card-body {
//   // height: 10dvh;
// }
.card-header {
  border: none;
  background: none;
}

.card-footer {
  background-color: rgba(60, 60, 60, 0.8);
  border: none;
  // margin: 0.3rem;
  // border-radius: none !important;

}

.recipe-category-bg {
  background-color: rgba(60, 60, 60, 0.8);


}

.favorite-button {
  position: absolute;
  top: 1%;
  right: 1%;
}
</style>