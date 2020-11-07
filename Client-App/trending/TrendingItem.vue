<template>
  <li class="trending-item">
    <section>
      <FontAwesomeIcon :icon="icon" />
      <h2>Trending Title</h2>
    </section>
    <h3>Description</h3>
    <p>
      Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc a tortor ut orci placerat
      porttitor. Mauris convallis, velit non tincidunt tincidunt, urna dui mollis neque, eget
      posuere quam turpis vitae lacus.
    </p>
  </li>
</template>

<script>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

export default {
  components: {
    FontAwesomeIcon,
  },

  props: {
    icon: {
      type: String,
      required: true,
    },
  },
};
</script>

<style>
.trending-item {
  background-color: rgba(0, 0, 0, 0.5);
  border-radius: 0.5rem;
  height: 14rem;
  padding: 1.5rem;
  overflow-y: auto;
}

.trending-item > section {
  align-items: center;
  display: flex;
  margin-bottom: 0.5rem;
}

.trending-item > section > h2 {
  margin-left: 1.5rem;
}

.trending-item > p {
  margin-top: 0.5rem;
  text-align: justify;
}

.trending-item svg {
  font-size: 3rem;
}
</style>
