<template>
  <div class="profile">
    <FontAwesomeIcon
      class="profile__close"
      :icon="['far', 'times-circle']"
      @click="$emit('close')"
    />

    <section class="profile__header">
      <div class="profile__header__picture">
        <FontAwesomeIcon v-if="!showPicture" icon="user" />
        <img v-if="showPicture" :src="profile.picture" alt="Profile Picture" />
      </div>

      <div class="profile__header__details">
        <section>
          <FontAwesomeIcon class="github" :icon="['fab', 'github']" />
          <FontAwesomeIcon class="linkedin" :icon="['fab', 'linkedin']" />
          <FontAwesomeIcon class="email" icon="envelope" />
        </section>

        <h1>{{ profile.title }} {{ profile.firstName }} {{ profile.lastName }}</h1>
        <h3>{{ profile.organization }}</h3>
      </div>
    </section>

    <section class="profile__details">
      <div class="profile__details__bio">
        <h3>Biography</h3>
        <p>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. In imperdiet nunc ac erat
          placerat, sed pellentesque tortor finibus. Praesent quis facilisis nunc, varius maximus
          nunc. Nulla maximus interdum justo sit amet lacinia. Suspendisse vitae semper mauris.
          Praesent elementum luctus aliquam. Aenean luctus suscipit erat vel dictum. Nullam eleifend
          massa sed mi efficitur, ut rhoncus felis posuere. Sed non maximus augue, at consequat
          lorem. Ut fermentum sit amet sem eget mattis. Etiam cursus mauris non ante consectetur, a
          faucibus lectus porta. Vestibulum sit amet porttitor nulla.
        </p>
      </div>

      <div class="profile_details__lists">
        <List name="Skills" :list="profile.skills" />
        <List name="Courses" :list="profile.courses" />
      </div>
    </section>
  </div>
</template>

<script>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

import List from './List.vue';

export default {
  components: {
    FontAwesomeIcon,
    List,
  },

  props: {
    profile: {
      type: Object,
      default: () => {},
    },
  },

  computed: {
    showPicture() {
      if (this.profile === {}) {
        return false;
      }

      if (
        this.profile !== {} &&
        (this.profile.picture !== undefined || this.profile.picture !== '')
      ) {
        return true;
      }
    },
  },
};
</script>

<style>
.profile {
  background-color: #444;
  border: 0.125rem solid #fff;
  border-radius: 0.5rem;
  display: flex;
  flex-direction: column;
  height: 40vh;
  padding: 1rem;
  position: relative;
  width: 40vw;
}

.profile__close {
  cursor: pointer;
  font-size: 1.7rem;
  right: 0.5rem;
  position: absolute;
  top: 0.5rem;
}

.profile__close:hover {
  background-color: #222;
  border-radius: 50%;
}

.profile__header {
  align-items: center;
  display: flex;
  height: 35%;
}

.profile__header__picture {
  align-items: center;
  border-radius: 0.5rem;
  display: flex;
  height: 8rem;
  justify-content: center;
  margin-right: 1rem;
  overflow: hidden;
  width: 8rem;
}

.profile__header__picture > svg {
  font-size: 6rem;
}

.profile__header__picture > img {
  height: 100%;
  object-fit: cover;
  width: 100%;
}

.profile__header__details > section {
  align-items: center;
  display: flex;
  margin-bottom: 1rem;
}

.profile__header__details > section > * {
  margin-right: 1rem;
}

.profile__header__details svg {
  cursor: pointer;
  font-size: 2rem;
}

.profile__header__details svg.github {
  background-color: #fff;
  border-radius: 50%;
  color: #000;
}

.profile__header__details svg.linkedin {
  color: dodgerblue;
}

.profile__header__details svg.email {
  color: rgb(190, 0, 0);
  font-size: 2.15rem;
}

.profile__details {
  display: flex;
  height: calc(65% - 3.5rem);
  margin-top: 1.5rem;
}

.profile__details__bio {
  margin-right: 0.6rem;
  width: 50%;
}

.profile__details__bio > p {
  height: 100%;
  margin-top: 0.5rem;
  overflow-y: auto;
  padding-right: 0.8rem;
  text-align: justify;
}

.profile_details__lists {
  margin-left: 0.6rem;
  width: 50%;
}

.profile_details__lists > * {
  margin-bottom: 1rem;
}
</style>
