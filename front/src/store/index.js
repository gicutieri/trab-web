import Vue from "vue";
import Vuex from "vuex";

import Home from "./home.module";
import Loja from "./loja.module";
import Carrinho from "./carrinho.module";

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    Home,
    Loja,
    Carrinho
  }
});
