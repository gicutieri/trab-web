import ApiService from "@/common/api.service";
import JwtService from "@/common/jwt.service";
import {
    LOGIN,
    LOGOUT
  } from "./actions.type";
  import { 
      SET_AUTH, 
      PURGE_AUTH, 
      SET_ERROR } from "./mutations.type";

  const state = {
    errors: null,
    user: {},
    isAuthenticated: !!JwtService.getToken()
  };

  const getters = {
    currentUser(state) {
      return state.user;
    },
    isAuthenticated(state) {
      return state.isAuthenticated;
    }
  };

  const actions = {
    [LOGIN](context, credentials) {
      return new Promise(resolve => {
        ApiService.post("Auth/Post", credentials)
          .then(({ data }) => {
            context.commit(SET_AUTH, data);
            resolve(data);
          })
          .catch(({ response }) => {
            context.commit(SET_ERROR, response.data);
          });
      });
    },
     [LOGOUT](context) {
       context.commit(PURGE_AUTH);
     },
  };
  
  const mutations = {
    [SET_ERROR](state, errors) {
      state.errors = errors;
    },
    [SET_AUTH](state, user) {
      state.isAuthenticated = true;
      state.user = user;
      state.errors = {};
      JwtService.saveToken(state.user.access_token);
    },
    [PURGE_AUTH](state) {
      state.isAuthenticated = false;
      state.user = {};
      state.errors = {};
      JwtService.destroyToken();
    }
  };
  
  export default {
    state,
    actions,
    mutations,
    getters
  };
  