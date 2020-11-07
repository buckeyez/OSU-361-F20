<template>
  <ul class="result-list">
    <ResultItem
      v-for="p in profilesToShow"
      :key="p.firstName + p.lastName"
      :name="`${p.title} ${p.firstName} ${p.lastName}`"
      :org="p.organization"
      :picture="p.picture"
    />
  </ul>
</template>

<script>
import ResultItem from './ResultItem.vue';

export default {
  components: {
    ResultItem,
  },

  props: {
    filter: {
      type: String,
      default: '',
    },

    profiles: {
      type: Array,
      default: () => [],
    },
  },

  computed: {
    profilesToShow() {
      return this.filter === ''
        ? this.profiles
        : this.profiles.filter(p => this.filterPredicate(p));
    },
  },

  methods: {
    filterPredicate(profile) {
      const filterLC = this.filter.toLowerCase();
      return (
        profile.firstName.toLowerCase().includes(filterLC) ||
        profile.lastName.toLowerCase().includes(filterLC)
      );
    },
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
