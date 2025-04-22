<script setup>
import { Recipe } from '@/models/Recipe.js';

defineProps({
  recipeProp: { type: Recipe, required: true }
})
</script>


<!-- <div>{{ recipeProp.title }}</div> -->
<template>
  <div class="card mt-4 shadow text-light" :style="{ backgroundImage: `url(${recipeProp.img})` }">
    <div class="card-header d-flex justify-content-between align-items-center"><span
        class="recipe-category-bg rounded-pill px-3">{{ recipeProp.category }}</span>
      <button class="btn recipe-category-bg">
        <span class="mdi mdi-heart text-danger"></span>
      </button>
    </div>
    <div class="card-body"></div>
    <div class="card-footer fs-5 fw-bold">{{ recipeProp.title }}</div>
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
</style>