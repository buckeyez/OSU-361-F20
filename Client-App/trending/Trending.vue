<template>
  <div class="trending">
    <h2>Trending</h2>
    <span />
    <ul>
      <TrendingItem icon="graduation-cap" />
      <TrendingItem icon="code" />
      <TrendingItem icon="school" />
    </ul>
  </div>
</template>

<script>
import TrendingItem from './TrendingItem.vue';

export default {
  components: {
    TrendingItem,
  },
};
</script>

<style>
.trending {
  background-color: rgba(87, 87, 87, 0.7);
  border-radius: 0.5rem 0 0 0;
  display: flex;
  flex-direction: column;
  flex-shrink: 0;
  height: 100%;
  padding: 1rem;
  width: 25rem;
}

.trending > h2 {
  text-transform: uppercase;
}

.trending > span {
  background-color: #fff;
  height: 0.125rem;
  margin: 0.5rem 0;
  width: 100%;
}

.trending > ul {
  height: 100%;
  margin-top: 0.5rem;
  overflow-y: auto;
}

.trending > ul > li {
  margin-bottom: 2rem;
}
</style>
