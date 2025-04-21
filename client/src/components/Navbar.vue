<script setup>
import { ref, watch } from 'vue';
import { loadState, saveState } from '../utils/Store.js';
import Login from './Login.vue';

const theme = ref(loadState('theme') || 'light')

// function toggleTheme() {
//   theme.value = theme.value == 'light' ? 'dark' : 'light'
// }

watch(theme, () => {
  document.documentElement.setAttribute('data-bs-theme', theme.value)
  saveState('theme', theme.value)
}, { immediate: true })

</script>

<template>
  <nav class="navbar navbar-expand-md bg-codeworks">
    <div class="container gap-2">
      <RouterLink :to="{ name: 'Home' }" class="d-flex align-items-center text-light">
        <!-- <img class="navbar-brand" alt="logo" src="/img/cw-logo.png" height="45" /> -->
        <b class="fs-5">All Spice</b>
      </RouterLink>
      <!-- collapse button -->
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbar-links"
        aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="mdi mdi-menu text-light"></span>
      </button>
      <!-- collapsing menu -->
      <div class="collapse navbar-collapse" id="navbar-links">
        <ul class="navbar-nav">
          <li>
            <RouterLink :to="{ name: 'About' }" class="btn text-green selectable">
              About
            </RouterLink>
          </li>
        </ul>
        <!-- LOGIN COMPONENT HERE -->
        <div class="ms-auto">
          <!-- <button class="btn text-light" @click="toggleTheme"
            :title="`Enable ${theme == 'light' ? 'dark' : 'light'} theme.`">
            <i v-if="theme == 'dark'" class="mdi mdi-weather-sunny"></i>
            <i v-if="theme == 'light'" class="mdi mdi-weather-night"></i>
          </button> -->
        </div>
        <Login />
      </div>
    </div>
  </nav>
  <div class="container-fluid navbarPictureBg">
    <Login />
    <div class="row navbarPicture text-light sahitya-regular">
      <div class="col-12 d-flex align-items-center flex-column justify-content-center">
        <h1 class="">All-spice</h1>
        <h2 class=""> Cherish your cooking and their family </h2>
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
  width: 100%;
  margin: none;
  padding: none;
  height: 40dvh;
  // object-fit: cover;
  // transform: rotate(90deg);
}
.navbarPictureBg{
  background-image: url("https://images.unsplash.com/photo-1612549225312-900aa64d56bb?q=80&w=2940&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
  background-size: cover;
  background-position: center;

}
</style>
