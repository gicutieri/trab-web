<template>  
    <div class="col-sm-3">
      <div class="card">
        <img :src="'/imagens/abacate.jpg'" class="card-img-top" v-bind:alt="destaque.nome" />
          <div class="card-body">
            <h3 class="card-title">{{ destaque.nome }}</h3>
            <h5>{{ destaque.preco }} {{ destaque.descricao }}</h5>
          </div>
      </div>
    </div>
</template>

<script>
export default {
  name: 'Card',
  props: {
    destaque: { type: Object, required: true }
  },
}
</script>

<style scoped>

</style>