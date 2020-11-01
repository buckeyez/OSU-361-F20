<template>
  <div class="example-component">
    <h1>{{ userData.name }}</h1>
    <h2>{{ userData.email }}</h2>
    <span>Just some filler content that is formated with styling...</span>
  </div>
</template>

<script>
import Axios from 'axios';

export default {
  data() {
    return {
      userData: {},
    };
  },

  created() {
    Axios.get('/user/mason').then(res => (this.userData = res.data));
  },
};
</script>

<style>
.example-component {
  align-items: center;
  display: flex;
  flex-direction: column;
  justify-content: center;
  height: 100%;
}

.example-component > span {
  color: crimson;
}
</style>
