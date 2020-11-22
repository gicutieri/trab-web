<template>  
  <div class="col-sm-3">
    <div class="card">
      <img v-bind:src="this.imagem" class="card-img-top" v-bind:alt="this.nome" />
        <div class="card-body">
          <h3 class="card-title">{{ this.nome }}</h3>
          <h5>{{ this.preco }} {{ this.descricao }}</h5>
        </div>
        <button @click="remover(this.quantidade)">-</button> 
        <p>{{this.quantidade}}</p>
        <button @click="adicionar(this.quantidade)">+</button> 
    </div>
  </div>
</template>

<script>
export default {
  name: 'Card',
  props: {
    imagem: String,
    nome: String,
    descricao: String,
    preco: Number,
    quantidade: Number
  },
  methods:{
    remover(qtd){
      return qtd - 1;
    },
    adicionar(qtd){
      return qtd + 1;
    },
  }
}
</script>

<style scoped>

</style>