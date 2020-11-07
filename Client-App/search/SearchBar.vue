<template>
  <div class="search-bar">
    <input type="text" placeholder="Search" />
    <span><FontAwesomeIcon icon="search" /></span>
  </div>
</template>

<script>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

export default {
  components: {
    FontAwesomeIcon,
  },
};
</script>

<style>
.search-bar {
  align-items: center;
  display: flex;
  height: 2.4rem;
  width: 50%;
}

.search-bar > input {
  border-radius: 0.5rem 0 0 0.5rem;
  height: 100%;
  width: 100%;
}

.search-bar > span {
  align-items: center;
  background-color: #666;
  border: 0.125rem solid #fff;
  border-left: none;
  border-radius: 0 0.5rem 0.5rem 0;
  cursor: pointer;
  display: flex;
  font-size: 1.2rem;
  height: 100%;
  justify-content: center;
  padding: 0 0.9rem;
}
</style>
