<template>  
    <div class="col-xl-3 col-md-6">
      <div class="card">
        <img :src="'/imagens/ABACATE.jpg'" class="card-img-top cardimagem" v-bind:alt="produto.nome" />
        <div class="card-body cardfundo">
          <h3 class="card-title cardtitle">{{ produto.nome }}</h3>
          <div class="container-fluid">
            <div class="row">
              <div class="col" style="padding: 0px 5px">
                <h5 class="precocard" style="font-family: Montserrat">{{ produto.preco }} {{ produto.descricao }}</h5>
              </div>
              <div class="col-6">
                <div id="buttons">
                  <div align="center">
                    <button v-on:click="removerQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                      <span>-</span>
                    </button>
                    <button class="btn btn-sm btn-outline-dark inline-block-child"> {{ quantidade }} </button>
                    <button v-on:click="adicionarQuantidade()" class="btn btn-sm btn-outline-dark inline-block-child">
                      <span><i class="fa fa-arrow-right"></i>+</span>
                    </button>
                </div>
              </div>
            </div>             
          </div>
        </div>
        </div>
      </div>
    </div>
</template>

<script>
export default {
  name: 'Card',
  props: {
    produto: { type: Object, required: true }
  },
  data: function () {
    return {
      quantidade: 0
    }
  },
  mounted () {
    let qtd = 0;
    let carrinho = this.recuperarCarrinho();
    
    carrinho.forEach(element => {
      if (this.produto.id == element.id) {
        qtd = element.quantidade;
      }
    });

    this.quantidade = qtd;
  },
  methods: {
    adicionarQuantidade: function () {
      this.quantidade += 1;
      this.atualizarCarrinho();
    },
    removerQuantidade: function () {
      if (this.quantidade == 0) return;
      this.quantidade -= 1;
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
      let count = -1;
      let index = -1;
      let carrinho = this.recuperarCarrinho();
      
      carrinho.forEach(element => {
        count++;
        if (this.produto.id == element.id) {
          element.quantidade = this.quantidade;
          foraDoCarrinho = 0;
          index = count;
        }
      });

      if (index > -1 && this.quantidade == 0){
        carrinho.splice(index, 1);
      }

      if (foraDoCarrinho) {
        this.produto.quantidade = this.quantidade;
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
  background-color: rgba(196, 196, 196, 0.7);
  border-radius: 10px;
}
.cardfundo{
  background: rgba(196, 196, 196, 0);
  border-radius: 10px;
}
.cardimagem{
  filter: drop-shadow(0px 4px 4px rgba(0, 0, 0, 0.25));
border-radius: 10px;
}
</style>