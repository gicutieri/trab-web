import { DestaqueService } from "@/common/api.service";
import { FETCH_DESTAQUES } from "./actions.type";
import { SET_DESTAQUES } from "./mutations.type";

const state = {
    destaques: [],
}

const getters = {
    destaques(state) {
        return state.destaques;
    }
};

const actions = {
    [FETCH_DESTAQUES]({ commit }) {
        return DestaqueService.get()
            .then(({ data }) => {
            commit(SET_DESTAQUES, data);
        })
        .catch(error => {
            throw new Error(error);
        });
    }
};

const mutations = {
    [SET_DESTAQUES](state, destaques) {
        state.destaques = destaques;
    }
};

export default {
    state,
    getters,
    actions,
    mutations
};