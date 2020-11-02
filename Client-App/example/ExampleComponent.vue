<template>
  <div class="example-component">
    <h1>User Data</h1>
    <h2>{{ userData.name }}</h2>
    <h2>{{ userData.email }}</h2>

    <span>Just some filler content that is formated with styling...</span>

    <h1>Profile Data</h1>
    <h2>{{ profileData.title }} {{ profileData.firstName }} {{ profileData.lastName }}</h2>
    <h2>Skills</h2>
    <ul>
      <li v-for="skill in profileData.skills" :key="skill">{{ skill }}</li>
    </ul>
  </div>
</template>

<script>
import Axios from 'axios';

export default {
  data() {
    return {
      userData: {},
      profileData: {},
    };
  },

  created() {
    Axios.get('/user/mason').then(res => (this.userData = res.data));
    Axios.get('/profile/1').then(res => (this.profileData = res.data));
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

.example-component > * {
  padding: 0.2rem;
}

.example-component > span {
  color: crimson;
  margin: 1rem 0;
}
</style>
