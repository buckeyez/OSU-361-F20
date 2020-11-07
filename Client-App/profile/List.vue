<template>
  <div class="profile-list">
    <h3>{{ name }}</h3>

    <ul>
      <li v-for="item in list" :key="item">{{ item }}</li>
    </ul>
  </div>
</template>

<script>
export default {
  props: {
    name: {
      type: String,
      required: true,
    },

    list: {
      type: Array,
      default: () => [],
    },
  },
};
</script>

<style>
.profile-list > h3 {
  margin: 0 0 0.4rem 0.25rem;
}

.profile-list > ul {
  display: flex;
  flex-wrap: wrap;
}

.profile-list > ul > li {
  border: 0.125rem solid #222;
  border-radius: 1rem;
  margin-right: 0.5rem;
  padding: 0.2rem 0.7rem;
}
</style>
