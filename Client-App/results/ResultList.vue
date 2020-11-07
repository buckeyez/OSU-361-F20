<template>
  <ul class="result-list">
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
    <ResultItem />
  </ul>
</template>

<script>
import ResultItem from './ResultItem.vue';

export default {
  components: {
    ResultItem,
  },
};
</script>

<style>
.result-list {
  display: flex;
  flex-wrap: wrap;
  height: calc(100% - 14rem);
  justify-content: center;
  margin-top: 2rem;
  overflow-y: auto;
  width: 90%;
}
</style>
