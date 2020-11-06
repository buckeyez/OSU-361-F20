<template>
  <li class="result-button">
    <FontAwesomeIcon icon="user" />

    <section>
      <h3>Profile Placeholder</h3>
    </section>
  </li>
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
.result-button {
  align-items: center;
  background-color: rgba(87, 87, 87, 0.7);
  border-radius: 0.5rem;
  display: flex;
  flex-direction: column;
  height: 14rem;
  margin: 2rem;
  padding-top: 1.5rem;
  width: 14rem;
}

.result-button > svg {
  font-size: 6.5rem;
}

.result-button > section {
  background-color: #222;
  border-radius: 0 0 0.5rem 0.5rem;
  height: 35%;
  margin-top: auto;
  padding: 0.5rem;
  width: 100%;
}

.result-button > section > h3 {
  text-align: center;
  width: 100%;
}
</style>
