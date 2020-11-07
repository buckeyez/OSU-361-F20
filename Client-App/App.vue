<template>
  <div class="app">
    <VideoBackground src="/dist/background_lines.mp4" style="height: 100vh; width: 100vw;">
      <div class="app__content">
        <Header />

        <div class="app__content__body">
          <section>
            <SearchBar />

            <ResultList />
          </section>

          <Trending />
        </div>
      </div>
    </VideoBackground>
  </div>
</template>

<script>
require('./assets/video/background_lines.mp4');

import Header from './header/Header.vue';
import ResultList from './results/ResultList.vue';
import SearchBar from './search/SearchBar.vue';
import Trending from './trending/Trending.vue';

export default {
  components: {
    Header,
    ResultList,
    SearchBar,
    Trending,
  },

  data() {
    return {
      showExample: true,
    };
  },

  computed: {
    showPlaceHolder() {
      return !this.showExample;
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
