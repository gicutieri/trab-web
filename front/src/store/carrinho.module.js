import { FETCH_CARRINHO, UPDATE_CARRINHO } from "./actions.type";
import { SET_CARRINHO } from "./mutations.type";

const state = {
    carrinho: [],
}

const getters = {
    carrinho(state) {

        if (localStorage.getItem('carrinho')) {
            state.carrinho = JSON.parse(localStorage.getItem('carrinho'));
        } else {
            state.carrinho = [];
        }

        return state.carrinho;
    }
};

const actions = {
    [FETCH_CARRINHO]({ commit }) {
        let carrinho = [];

        if (localStorage.getItem('carrinho')) {
            carrinho = JSON.parse(localStorage.getItem('carrinho'));
        }

        commit(SET_CARRINHO, carrinho);
    },
    [UPDATE_CARRINHO]({ commit }, produto) {
        
        let foraDoCarrinho = 1;
        let index = -1;
        let carrinho = state.carrinho;

        carrinho.forEach((element, count) => {
            if (produto.Id == element.Id) {
                element.Quantidade = produto.Quantidade;
                foraDoCarrinho = 0;
                index = count;
            }
        });

        if (index > -1 && produto.Quantidade == 0) {
            carrinho.splice(index, 1);
        }

        if (foraDoCarrinho) {
            carrinho.push(produto);
        }

        commit(SET_CARRINHO, carrinho);
    },
};

const mutations = {
    [SET_CARRINHO](state, carrinho) {
        state.carrinho = carrinho;
        const parsed = JSON.stringify(carrinho);
        localStorage.setItem('carrinho', parsed);
    }
};

export default {
    state,
    getters,
    actions,
    mutations
};