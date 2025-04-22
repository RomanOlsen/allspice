<script setup>
import { Recipe } from '@/models/Recipe.js';

defineProps({
  recipeProp: {type: Recipe, required: true}
})
</script>


<template>
  <div>Sup jerms{{ recipeProp?.title }}</div>
</template>


<style lang="scss" scoped></style>