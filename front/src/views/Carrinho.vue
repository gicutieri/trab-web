<template>
  <div class="carrinho">
    <div class="container">
      <div class="row">
        <div class="col-md-8">
          <div class="row">
            <div class="shape">
              <h2 class="shapecontent">CARRINHO</h2>
            </div>
          </div>
          <div class="container cart">
            <Card v-for="(produto, index) in this.carrinho" :type="'detalhado'" :produto="produto" :key="index"></Card>
          </div>
        </div>

        <div class="col-md-4">
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
      </div> <!-- <div class="row"> -->
    </div> <!-- <div class="container"> -->
  </div>
</template>

<script>
import Card from '@/components/Card.vue'
import { mapGetters } from "vuex";

export default {
  name: 'Carrinho',
  components: {
    Card
  },
  data: function () {
    return {
      subTotal: 0,
      total: 0,
    }
  },
  computed: {
    ...mapGetters(["carrinho"]),
  },
  mounted () {

    this.subTotal = 0;
    this.total = 0;
    
    this.carrinho.forEach(element => {
      this.subTotal += element.Preco * element.Quantidade;
    });

    this.total = this.subTotal;
  },
}
</script>

<style scoped>
#finalizar{
  margin-top: 5px;
}
</style>