<template>
  <div v-bind:class="classCard">
    <div v-if="this.type == 'resumido'" class="card">
      <img v-bind:src="produto.Imagem" class="card-img-top cardimagem" v-bind:alt="produto.Nome" />
      <div class="card-body cardfundo">
        <h3 class="card-title cardtitle">{{ produto.Nome }}</h3>
        <div class="container-fluid">
          <div class="row">
            <div class="col-6" style="padding: 0px 5px">
              <h5 class="precocard" style="font-family: Montserrat">{{ produto.Preco }} {{ produto.Descricao }}</h5>
            </div>
            <div class="col-6">
              <div id="buttons">
                <div align="center">
                  <button v-on:click="removerQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                    <span>-</span>
                  </button>
                  <button class="btn btn-sm btn-outline-dark inline-block-child"> {{ Quantidade }} </button>
                  <button v-on:click="adicionarQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                    <span>+</span>
                  </button>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div v-if="this.type == 'detalhado'" class="row">
      <div class="col-sm-4">
        <img src="/imagens/abacate.jpg" alt="foto do produto" class="card-img-top">
      </div>
      <div class="container col-sm-8">
        <div class="row">
          <div class="col-sm-6">{{ this.produto.Nome }}</div>
          <div class="col-sm-4">{{ this.produto.Preco * this.produto.Quantidade }}</div>
          <div class="col-sm-2"><b-icon icon="trash-fill" variant="dark" aria-hidden="true">te</b-icon></div>
        </div>
        <div class="row">
          <div class="col-sm-12">{{ this.produto.Preco }}</div>
        </div><div class="row">
          <div class="col-sm-12">
            <div id="buttons">
              <button v-on:click="removerQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                <span>-</span>
              </button>
              <button class="btn btn-sm btn-outline-dark inline-block-child"> {{ Quantidade }} </button>
              <button v-on:click="adicionarQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                <span><i class="fa fa-arrow-right"></i>+</span>
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>

    <hr v-if="this.type == 'detalhado'" class="my-4">

  </div>
</template>

<script>
import { BIcon } from 'bootstrap-vue'

export default {
  name: 'Card',
  components: {
    'b-icon': BIcon,
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
    let carrinho = this.recuperarCarrinho();
    
    carrinho.forEach(element => {
      if (this.produto.Id == element.Id) {
        console.log('entrei');
        qtd = element.Quantidade;
      }
    });

    this.Quantidade = qtd;
  },
  computed: {
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
      this.atualizarCarrinho();
    },
    removerQuantidade: function () {
      if (this.Quantidade == 0) return;
      this.Quantidade -= 1;
      this.atualizarCarrinho();
    },
    recuperarCarrinho: function() {
      let carrinho = [];

      if (localStorage.getItem('carrinho')) {
        carrinho = JSON.parse(localStorage.getItem('carrinho'));
      }

      return carrinho;
    },
    atualizarCarrinho: function() {
      let foraDoCarrinho = 1;
      let index = -1;
      let carrinho = this.recuperarCarrinho();
      
      carrinho.forEach((element, count) => {
        if (this.produto.Id == element.Id) {
          element.Quantidade = this.Quantidade;
          foraDoCarrinho = 0;
          index = count;
        }
      });

      if (index > -1 && this.Quantidade == 0){
        carrinho.splice(index, 1);
      }

      if (foraDoCarrinho) {
        this.produto.Quantidade = this.Quantidade;
        carrinho.push(this.produto);
      }

      this.salvarCarrinho(carrinho);
    },
    salvarCarrinho: function(obj) {
      const parsed = JSON.stringify(obj);
      localStorage.setItem('carrinho', parsed);
    }
  }
}
</script>

<style scoped>
.inline-block-child{
    display: inline-block;
  }
.precocard{
  font-family: Montserrat;
  font-style: normal;
  font-weight: 500;
  font-size: 20px;
  line-height: 15px;
  text-align: center;
  margin-top: 8px;
  color: #AF7061;
}
.cardtitle{
font-family: Montserrat;
font-style: normal;
font-weight: 500;
font-size: 25px;
line-height: 10px;
text-align: center;

color: #AF7061;
}
.card{
  background-color: rgb(255, 255, 255);
  border-radius: 10px;
  margin-bottom: 10px;
}
.cardfundo{
  background: rgba(196, 196, 196, 0);
  border-radius: 10px;
  padding-left: 5px;
  padding-right: 5px;
}
.cardimagem{
  filter: drop-shadow(0px 4px 4px rgba(0, 0, 0, 0.25));
border-radius: 10px;
}
.col{
  padding-bottom: 5px;
}
</style>