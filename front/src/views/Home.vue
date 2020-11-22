<template>
  <div class="home">
    <Carousel/>
    <div class="container">
      <div class="row">
        <div class="shape">
          <h2 class="shapecontent">DESTAQUES</h2>
        </div>
      </div>
      <div class="row">
        <Card v-for="(destaque, index) in destaques" :destaque="destaque" :key="index">
        </Card>
      </div>
      <div class="row">
        <div class="shape">
          <h2 class="shapecontent">ORIGEM</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 py-5">
          <img src="@/assets/Home/diagrama.svg" alt="diagrama da origem de nossos produtos, mostrando o caminho do produtor, transporte, canal de distribui��o e a chegada ao cliente." class="mximg-responsive center-block d-block img-fluid mx-auto">
        </div>
      </div>
      <div class="row">
        <div class="shape">
          <h2 class="shapecontent">SOBRE NÓS</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 py-5">
          <p id="descricao-producao" class="justify-content">
            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
          </p>      
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapGetters } from "vuex";
import Carousel from '@/components/Carousel.vue'
import Card from '@/components/Card.vue'
import { FETCH_DESTAQUES } from "@/store/actions.type";

export default {
  name: 'Home',
  components: {
    Carousel,
    Card
  },
  mounted() {
    this.$store.dispatch(FETCH_DESTAQUES);
  },
  computed: {
    ...mapGetters(["destaques"])
  }
}
</script>

<style scoped>

</style>