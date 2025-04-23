<script setup>
import { AppState } from '@/AppState.js';
import { computed } from 'vue';

const recipe = computed(() => AppState.activeRecipe)
</script>


<template>
  <div id="RecipeDetailsModal" class="modal fade" tabindex="-1">
    <div  v-if="recipe" class="modal-dialog modal-xl">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">{{ recipe.title }}</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">


        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <button type="button" class="btn btn-primary">Save changes</button>
        </div>
      </div>
    </div>



    <!-- SECTION loading -->
    <div v-else class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Loading <span class="mdi mdi-loading mdi-spin"></span></h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
          <p>Give it a moment.</p>
        </div>
      </div>
    </div>
  </div>
</template>


<style lang="scss" scoped></style>