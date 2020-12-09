<template>
    <div class="login">
        <div class="container page">
            <div class="row">
                <div class="col-md-6 offset-md-3 col-xs-12">
                    <h1 class="text-center white">Sign in</h1>
                    <p class="text-center">
                        <router-link :to="{ name: 'Cadastro' }" class="white">
                        Não tem conta ainda?
                        </router-link>
                    </p>
                    <ul v-if="errors" class="error-messages">
                        <li v-for="(erro) in errors" :key="erro">{{ erro }}</li>
                    </ul>
                    <form @submit.prevent="onSubmit(Email, Password)">
                        <fieldset class="form-group">
                            <input
                            class="form-control form-control-lg"
                            type="text"
                            v-model="Email"
                            placeholder="Email"
                            />
                        </fieldset>
                        <fieldset class="form-group">
                            <input
                            class="form-control form-control-lg"
                            type="password"
                            v-model="Password"
                            placeholder="Password"
                            />
                        </fieldset>
                        <button class="btn btn-lg btn-primary pull-right">
                            Entrar
                        </button>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { mapState } from "vuex";
import { LOGIN } from "@/store/actions.type";

export default {
  name: 'Login',
  components: {
  },
  data() {
    return {
      Email: null,
      Password: null
    };
  },
  methods: {
    onSubmit(Email, Password) {
      this.$store
        .dispatch(LOGIN, { Email, Password })
        .then(() => this.$router.push({ name: "Home" }));
    }
  },
  computed: {
    ...mapState({
      errors: state => state.Auth.errors
    })
  }
}
</script>

<style scoped>
.container.page {
    padding-top: 1.5rem;
}

.white {
    color: white;
}
</style>