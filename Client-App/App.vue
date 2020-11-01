<template>
  <div class="app">
    <h1 v-if="showPlaceHolder">Hello World!</h1>

    <ExampleComponent v-if="showExample" />
  </div>
</template>

<script>
import ExampleComponent from './example/ExampleComponent.vue';

export default {
  components: {
    ExampleComponent,
  },

  data() {
    return {
      showExample: true,
    };
  },

  computed: {
    showPlaceHolder() {
      return !this.showExample;
    },
  },
};
</script>

<style>
@import 'minireset.css/minireset';
@import './assets/css/app-styles.css';

.app {
  background-color: #444;
  color: white;
  height: 100vh;
  width: 100vw;
}
</style>
