<template>
  <div class="header">
    <h1>Expert Finder</h1>

    <h3 @click="$emit('sign-in')">{{ userText }}</h3>
  </div>
</template>

<script>
export default {
  props: {
    user: {
      type: String,
      default: '',
    },
  },

  computed: {
    userText() {
      return this.user === '' ? 'Sign In' : `Welcome ${this.user}`;
    },
  },
};
</script>

<style>
.header {
  align-items: center;
  background-color: rgba(87, 87, 87, 0.7);
  border-radius: 0 0 0.5rem 0.5rem;
  display: flex;
  height: 3.75rem;
  padding: 0 4rem 0 2rem;
  position: absoulte;
  top: 0;
  width: 100%;
}

.header > h1 {
  font-size: 3rem;
  font-weight: 900;
  text-transform: uppercase;
}

.header > h3 {
  cursor: pointer;
  margin-left: auto;
}
</style>
