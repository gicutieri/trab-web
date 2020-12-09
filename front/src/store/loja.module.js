import { ProdutoService } from "@/common/api.service";
import { FETCH_PRODUTOS } from "./actions.type";
import { SET_PRODUTOS } from "./mutations.type";

const state = {
    produtos: [],
}

const getters = {
    produtos(state) {
        return state.produtos;
    }
};

const actions = {
    [FETCH_PRODUTOS]({ commit }) {
        return ProdutoService.get()
            .then(({ data }) => {
            commit(SET_PRODUTOS, data);
        })
        .catch(error => {
            throw new Error(error);
        });
    }
};

const mutations = {
    [SET_PRODUTOS](state, produtos) {
        state.produtos = produtos;
    }
};

export default {
    state,
    getters,
    actions,
    mutations
};