import Vue from 'vue';
import App from './App.vue';

import { Plugin } from 'vue-responsive-video-background-player';
Vue.use(Plugin);

import { library } from '@fortawesome/fontawesome-svg-core';
import { faSearch, faUser } from '@fortawesome/free-solid-svg-icons';
library.add(faSearch, faUser);

const app = new Vue({
  render: h => h(App),
});

app.$mount('#app');
