<template>
  <ul class="result-list">
    <ResultItem
      v-for="(p, index) in profilesToShow"
      :key="index + p.firstName + p.lastName"
      :name="`${p.title} ${p.firstName} ${p.lastName}`"
      :org="p.organization"
      :picture="p.picture"
      @click="$emit('show-profile', index)"
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
      let found = false;
      found = profile.firstName.toLowerCase().includes(filterLC);
      found = found ? found : profile.lastName.toLowerCase().includes(filterLC);

      const proCourses = profile.courses.map(c => c.toLowerCase());
      for (let i = 0; i < proCourses.length; ++i) {
        found = found ? found : proCourses[i].includes(filterLC);
        if (found) {
          break;
        }
      }

      const proSkills = profile.skills.map(s => s.toLowerCase());
      for (let i = 0; i < proSkills.length; ++i) {
        found = found ? found : proSkills[i].includes(filterLC);
        if (found) {
          break;
        }
      }

      return found;
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
