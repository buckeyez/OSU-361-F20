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
  background-color: #999;
  border: 0.125rem solid #fff;
  border-radius: 0.5rem 0 0 0.5rem;
  font-size: 1.5rem;
  font-weight: 500;
  height: 100%;
  padding: 0 0.5rem;
  width: 100%;
}

.search-bar > input:focus {
  outline: none;
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
