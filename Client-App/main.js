import Vue from 'vue';
import App from './App.vue';

import { Plugin } from 'vue-responsive-video-background-player';
Vue.use(Plugin);

import Popover from 'vue-js-popover';
Vue.use(Popover, { tooltip: true });

import {
  faCode,
  faEnvelope,
  faGraduationCap,
  faSchool,
  faSearch,
  faUser,
} from '@fortawesome/free-solid-svg-icons';
import { faGithub, faLinkedin } from '@fortawesome/free-brands-svg-icons';
import { faTimesCircle } from '@fortawesome/free-regular-svg-icons';

import { library } from '@fortawesome/fontawesome-svg-core';
library.add(
  faCode,
  faEnvelope,
  faGithub,
  faGraduationCap,
  faLinkedin,
  faSchool,
  faSearch,
  faTimesCircle,
  faUser
);

const app = new Vue({
  render: h => h(App),
});

app.$mount('#app');
