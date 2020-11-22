<template>  
    <div class="col-sm-3">
      <div class="card">
        <img :src="'/imagens/abacate.jpg'" class="card-img-top" v-bind:alt="produto.nome" />
        <div class="card-body">
          <h3 class="card-title">{{ produto.nome }}</h3>
          <h5>{{ produto.preco }} {{ produto.descricao }}</h5>

          <div id="buttons" class="but">
            <div align="center">
              <button v-on:click="removerQuantidade()" class="btn btn-md btn-outline-dark inline-block-child" style="margin-right: 2%;">
                <span>-</span>
              </button>
              <button class="btn btn-md btn-outline-dark inline-block-child"> {{ quantidade }} </button>
              <button v-on:click="adicionarQuantidade()" class="btn btn-md btn-outline-dark inline-block-child" style="margin-left: 2%;">
                <span><i class="fa fa-arrow-right"></i>+</span>
              </button>
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

</style>