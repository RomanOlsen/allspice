<script setup>
import { AppState } from '@/AppState.js';
import Create from '@/components/Create.vue';
import RecipeCard from '@/components/RecipeCard.vue';
import { recipesService } from '@/services/RecipesService.js';
import { logger } from '@/utils/Logger.js';
import { Pop } from '@/utils/Pop.js';
import { computed, onMounted } from 'vue';

const recipes = computed(() => AppState.recipes)

onMounted(() => {
  getAllRecipes()
})

async function getAllRecipes() {
  try {
    await recipesService.getAllRecipes()
  }
  catch (error) {
    Pop.error(error, 'could not get recipes!');
    logger.log("could not get recipes", error)
  }
}

</script>

<template>
  <div class="container">
    <div class="row">
      <div class="col-12 d-flex justify-content-center">
        <div class="text-center choose-section bg-light rounded shadow">
          <!-- <div class="position-relative"> -->

          <button class="btn btn-light">Home</button>
          <button class="btn btn-light">My Recipes</button>
          <button class="btn btn-light">Favorites</button>
          <!-- </div> -->

        </div>
      </div>
      <div v-for="recipe in recipes" :key="recipe.id" class="px-5 col-12 col-sm-12 col-md-6 col-lg-4 col-xl-4">
        <RecipeCard :recipeProp="recipe" />
      </div>
    </div>
  </div>
  <Create />
</template>

<style scoped lang="scss">
.choose-section {
  position: absolute;
  top: 40dvh;
  z-index: 1;
  // left: 50%;
  // transform: translate(-50%, -50%);


}

// .position-relative{
//   position: relative;
//   text-align: center;
//   display: flex;
// }</style>
