<template>
  <div class="app">
    <VideoBackground src="/dist/background_lines.mp4" style="height: 100vh; width: 100vw;">
      <div class="app__content">
        <Header :user="loggedUser" @sign-in="showLogin = true" />

        <div class="app__content__body">
          <section>
            <SearchBar @search="searchHandler" />

            <ResultList
              :filter="searchValue"
              :profiles="profiles"
              @show-profile="showProfileHandler"
            />
          </section>

          <Trending />
        </div>
      </div>
    </VideoBackground>

    <Modal :active.sync="showLogin">
      <Login @cancel="showLogin = false" @login="loginHandler" />
    </Modal>

    <Modal :active.sync="showProfile">
      <Profile :profile="profileToShow" @close="closeProfileHandler" />
    </Modal>
  </div>
</template>

<script>
import Axios from 'axios';
require('./assets/video/background_lines.mp4');

import Header from './header/Header.vue';
import Login from './login/Login.vue';
import Modal from './modal/Modal.vue';
import Profile from './profile/Profile.vue';
import ResultList from './results/ResultList.vue';
import SearchBar from './search/SearchBar.vue';
import Trending from './trending/Trending.vue';

export default {
  components: {
    Header,
    Login,
    Modal,
    Profile,
    ResultList,
    SearchBar,
    Trending,
  },

  data() {
    return {
      loggedUser: '',
      profiles: [],
      profileToShow: {},
      searchValue: '',
      showLogin: false,
      showProfile: false,
    };
  },

  mounted() {
    Axios.get('profile/all').then(res => (this.profiles = res.data));
  },

  methods: {
    closeProfileHandler() {
      this.showProfile = false;
    },

    loginHandler(userName) {
      this.showLogin = false;
      this.loggedUser = userName;
    },

    showProfileHandler(profileNumber) {
      this.profileToShow = this.profiles[profileNumber];
      this.showProfile = true;
    },

    searchHandler(search) {
      this.searchValue = search;
    },
  },
};
</script>

<style>
@import 'minireset.css/minireset';
@import './assets/css/scrollbar.css';
@import './assets/css/app-styles.css';

.app {
  background-color: #444;
  color: white;
  height: 100vh;
  width: 100vw;
}

.app__content {
  background-color: rgba(0, 0, 0, 0.7);
  height: 100%;
  position: relative;
  width: 100%;
}

.app__content__body {
  display: flex;
  height: 100%;
  margin-top: 4rem;
  width: 100%;
}

.app__content__body > section {
  align-items: center;
  display: flex;
  flex-direction: column;
  flex-grow: 1;
  height: 100%;
  padding: 1rem 5rem 2rem 5rem;
}
</style>
