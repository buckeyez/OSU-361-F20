<template>
  <li class="result-button" @click="$emit('click', $event)">
    <FontAwesomeIcon v-if="picture === ''" icon="user" />
    <img v-if="picture !== ''" :src="picture" alt="Profile Picture" />

    <section>
      <h3>{{ displayName }}</h3>
      <span>{{ org }}</span>
    </section>
  </li>
</template>

<script>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

export default {
  components: {
    FontAwesomeIcon,
  },

  props: {
    name: {
      type: String,
      default: '',
    },

    org: {
      type: String,
      default: '',
    },

    picture: {
      type: String,
      default: '',
    },
  },

  computed: {
    displayName() {
      return this.name === '' ? 'Profile Placeholder' : this.name;
    },
  },
};
</script>

<style>
.result-button {
  transition: 0.3s ease-out;
  transition-property: border-color, transform;

  align-items: center;
  background-color: rgba(87, 87, 87, 0.7);
  border: 0.125rem solid transparent;
  border-radius: 0.5rem;
  cursor: pointer;
  display: flex;
  flex-direction: column;
  height: 14rem;
  margin: 0 2rem 3rem 2rem;
  overflow: hidden;
  transform: scale(0.97);
  width: 14rem;
}

.result-button:hover {
  border-color: #888;
  transform: scale(1);
}

.result-button > img {
  min-height: 75%;
}

.result-button > svg {
  font-size: 6.5rem;
}

.result-button > section {
  align-items: center;
  background-color: rgba(34, 34, 34, 0.7);
  border-radius: 0 0 0.5rem 0.5rem;
  display: flex;
  flex-direction: column;
  justify-content: center;
  margin-top: auto;
  min-height: 25%;
  width: 100%;
}

.result-button > section > h3 {
  text-align: center;
  width: 100%;
}
</style>
