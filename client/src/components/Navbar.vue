<script setup>
import { ref, watch } from 'vue';
import { loadState, saveState } from '../utils/Store.js';
import Login from './Login.vue';
import { logger } from '@/utils/Logger.js';

const theme = ref(loadState('theme') || 'light')

// function toggleTheme() {
//   theme.value = theme.value == 'light' ? 'dark' : 'light'
// }

watch(theme, () => {
  document.documentElement.setAttribute('data-bs-theme', theme.value)
  saveState('theme', theme.value)
}, { immediate: true })

function search() {
  logger.log("hi")
}
</script>

<template>

  <div class="container navbarPictureBg text-end rounded mt-4 shadow">

    <div class="row navbarPicture text-light sahitya-regular">
      <div class="col-12 d-flex justify-content-end align-items-center mb-5 pe-3">
        <form @submit.prevent="search()">
          <input id="searchbar" type="text" placeholder="Search..." required>
          <label for="searchbar"> <button class="btn"> <span class="mdi mdi-magnify"></span> </button></label>

        </form>
        <Login />
      </div>
      <div class="col-12 d-flex align-items-center flex-column mb-5 pb-5">
        <!-- i removed justify-content-center -->
        <h1 class="text-center sahitya-bold">All-Spice</h1>
        <h2 class="text-center"> Cherish your cooking and their family </h2>
      </div>

    </div>
  </div>






</template>

<style lang="scss" scoped>
a {
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 2px solid var(--bs-success);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}

.navbarPicture {
  // object-fit: cover;
  // width: 100%;
  margin: none;
  padding: none;
  height: 40dvh;
  // object-fit: cover;
  // transform: rotate(90deg);
}

.navbarPictureBg {
  background-image: url("https://images.unsplash.com/photo-1612549225312-900aa64d56bb?q=80&w=2940&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
  background-size: cover;
  background-position: center;

}
</style>
