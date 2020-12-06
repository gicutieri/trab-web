<template>
  <div v-bind:class="classCard" class="padding-left-right-15">
    <div v-if="this.type == 'resumido'" class="card">
      <img v-bind:src="produto.Imagem" class="card-img-top cardimagem" v-bind:alt="produto.Nome" />
      <div class="card-body cardfundo">
        <h3 class="card-title cardtitle">{{ produto.Nome }}</h3>
        <div class="container-fluid">
          <div class="row">
            <div class="col-6 clear-padding">
              <h5 class="precocard" style="font-family: Montserrat">{{ produto.Preco }} {{ produto.Descricao }}</h5>
            </div>
            <div class="col-6 clear-padding">
              <div id="buttons">
                <div align="center">
                  <button v-on:click="diminuirQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child margin-right-2">
                    <span><i class="fa fa-minus"></i></span>
                  </button>
                  <button class="btn btn-sm btn-outline-dark inline-block-child margin-right-2"> {{ Quantidade }} </button>
                  <button v-on:click="adicionarQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                    <span><i class="fa fa-plus"></i></span>
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div v-if="this.type == 'detalhado'" class="card">
      <div class="row">
        <div class="col-sm-4">
          <img v-bind:src="produto.Imagem" alt="foto do produto" class="card-img-top">
        </div>
        <div class="container col-sm-8">
          <div class="row">
            <div class="col-sm-6">{{ this.produto.Nome }}</div>
            <div class="col-sm-4">{{ this.produto.Preco * this.produto.Quantidade }}</div>
            <div class="col-sm-2">
              <button v-on:click="removerQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child margin-right-2">
                  <span><i class="fa fa-trash"></i></span>
                </button>
            </div>
          </div>
          <div class="row">
            <div class="col-sm-12">{{ this.produto.Preco }}</div>
          </div><div class="row">
            <div class="col-sm-12">
              <div id="buttons">
                <button v-on:click="diminuirQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child margin-right-2">
                  <span><i class="fa fa-minus"></i></span>
                </button>
                <button class="btn btn-sm btn-outline-dark inline-block-child margin-right-2"> {{ Quantidade }} </button>
                <button v-on:click="adicionarQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                  <span><i class="fa fa-plus"></i></span>
                </button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapGetters } from "vuex";
import { UPDATE_CARRINHO } from "@/store/actions.type";

export default {
  name: 'Card',
  components: {
    
  },
  props: {
    produto: { type: Object, required: true },
    type: {
      type: String,
      required: false,
      default: "resumido"
    },
  },
  data: function () {
    return {
      Quantidade: 0
    }
  },
  mounted () {
    let qtd = 0;
    let carrinho = this.carrinho;
    
    carrinho.forEach(element => {
      if (this.produto.Id == element.Id) {
        qtd = element.Quantidade;
      }
    });

    this.Quantidade = qtd;
  },
  computed: {
    ...mapGetters(["carrinho"]),
    classCard: function () {
      return {
        'col-xl-3': this.type == 'resumido',
        'col-md-6': this.type == 'resumido',
        'row': this.type == 'detalhado',
      }
    }
  },
  methods: {
    adicionarQuantidade: function () {
      this.Quantidade += 1;
      this.produto.Quantidade = this.Quantidade;
      this.$store.dispatch(UPDATE_CARRINHO, this.produto);
    },
    diminuirQuantidade: function () {
      if (this.Quantidade == 0) return;
      this.Quantidade -= 1;
      this.produto.Quantidade = this.Quantidade;
      this.$store.dispatch(UPDATE_CARRINHO, this.produto);
    },
    removerQuantidade: function () {
      if (this.Quantidade == 0) return;
      this.Quantidade = 0;
      this.produto.Quantidade = this.Quantidade;
      this.$store.dispatch(UPDATE_CARRINHO, this.produto);
    },
  }
}
</script>

<style scoped>

.inline-block-child {
  display: inline-block;
}

.precocard {
  font-family: Montserrat;
  font-style: normal;
  font-weight: 500;
  font-size: 20px;
  line-height: 15px;
  text-align: center;
  margin-top: 8px;
  color: #AF7061;
}

.cardtitle {
  font-family: Montserrat;
  font-style: normal;
  font-weight: 500;
  font-size: 25px;
  line-height: 10px;
  text-align: center;
  color: #AF7061;
}

.card {
  background-color: rgba(196, 196, 196, 0.7);
  border-radius: 10px;
}

.cardfundo {
  background: rgba(196, 196, 196, 0);
  border-radius: 10px;
}

.cardimagem {
  filter: drop-shadow(0px 4px 4px rgba(0, 0, 0, 0.25));
  border-radius: 10px;
}

.clear-padding {
  padding-right: 0;
  padding-left: 0;
}

.padding-left-right-15 {
  padding-top: 15px;
  padding-bottom: 15px;
}

.margin-right-2 {
  margin-right: 2px;
}
</style>