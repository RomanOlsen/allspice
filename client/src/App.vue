<script setup>
import Create from './components/Create.vue';
import Navbar from './components/Navbar.vue';
import { RouterView } from 'vue-router';

</script>

<template>
  <header>
    <Navbar />
  </header>
  <main class="sahitya-regular">
    <RouterView />
  </main>
  <footer class=" text-center">
    <!-- Made with <i class="mdi mdi-heart text-pink"></i> by CodeWorks -->
  </footer>
</template>

<style lang="scss"></style>
