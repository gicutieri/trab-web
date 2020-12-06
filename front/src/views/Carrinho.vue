<template>
  <div class="carrinho">
    <div class="container">
      <div class="row">
        <div class="col-md-8">
          <div class="carback">
            <div class="row">
              <div class="shape">
                <h2 class="shapecontent">CARRINHO</h2>
              </div>
            </div>
            <div class="container cart">
              <Card v-for="(produto, index) in this.carrinho" :type="'detalhado'" :produto="produto" :key="index"></Card>
            </div>
          </div>
        </div>

        <div class="col-md-4">
          <div class="carback">
                      <div class="row">
            <div class="shape">
              <h2 class="shapecontent">RESUMO</h2>
            </div>
          </div>
          <div class="container cart">
            <div class="row">
              <div class="col-sm-6">Sub-Total</div>
              <div class="col-sm-6 text-lg-right">{{ this.subTotal }}</div>
            </div>
            <div class="row">
              <div class="col-sm-6">Envio</div>
              <div class="col-sm-6 text-lg-right">Grátis</div>
            </div>
            <div class="row">
              <div class="col-sm-12">São Carlos, Brasil</div>
            </div>

            <hr class="my-4">

            <div class="row">
              <div class="col-sm-6">Total</div>
              <div class="col-sm-6 text-lg-right">{{ this.total }}</div>
            </div>
            <div class="row justify-content-md-center">
              <div class="col-sm-12">
                <button id="finalizar" @click="$router.push({ name: 'Pagamento' })" type="button" class="btn btn-secondary btn-lg btn-block btn-outline-light">Finalizar Compra</button>
              </div>
            </div>
          </div>
          </div>

        </div>
      </div> <!-- <div class="row"> -->
    </div> <!-- <div class="container"> -->
  </div>
</template>

<script>
import Card from '@/components/Card.vue'

export default {
  name: 'Carrinho',
  components: {
    Card
  },
  data: function () {
    return {
      carrinho: [],
      subTotal: 0,
      total: 0,
    }
  },
  mounted () {
    this.carrinho = this.recuperarCarrinho();
    
    this.carrinho.forEach(element => {
      this.subTotal += element.preco * element.quantidade;
    });

    this.total = this.subTotal;
  },
  methods: {
    recuperarCarrinho: function() {
      let carrinho = [];

      if (localStorage.getItem('carrinho')) {
        carrinho = JSON.parse(localStorage.getItem('carrinho'));
      }

      return carrinho;
    },
  },
}
</script>

<style scoped>
#finalizar{
  margin-top: 5px;
}
.carback{
  background-color: rgba(255, 255, 255, 0.7);
  /*border: 1px solid black;*/ 
  border-radius: 10px;
  margin-top: 5px;
  padding-right: 5px;
  padding-left: 5px;
}
</style>