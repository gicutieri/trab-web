import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from "./store";
import ApiService from "./common/api.service";

import '@babel/polyfill'
import 'mutationobserver-shim'
import './plugins/bootstrap-vue'

Vue.config.productionTip = false;

ApiService.init();

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
