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
        <Card v-for="(produto, index) in destaques" :produto="produto" :key="index"></Card>
      </div>
      <div class="row">
        <div class="shape">
          <h2 class="shapecontent">ORIGEM</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 py-5">
          <img src="@/assets/Home/diagrama.svg" alt="diagrama da origem de nossos produtos, mostrando o caminho do produtor, transporte, canal de distribui��o e a chegada ao cliente." class="mximg-responsive diagrama center-block d-block img-fluid mx-auto">
        </div>
      </div>
      <div class="row">
        <div class="shape">
          <h2 class="shapecontent">SOBRE NÓS</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-12 py-5">
          <div class="fundobranco">
                      <p class="justify-content sobree">
            Partiu-se do conceito de uma empresa fictícia ligada a produtos orgânicos, mercado o qual cresce continuamente em nosso país, em razão da alta divulgação dos efeitos adversos dos agrotóxicos em nossa saúde e ao meio ambiente, consequentemente a denominamos de YBY, que no Tupi-Guarani significa terra.
          </p>
          <p class="justify-content sobree">
            A YBY consiste em conectar a agriculta familiar diretamente com o consumidor final, sem a necessidade de mercados ou outros mediadores. Desta forma assegurando uma alta qualidade dos produtos, aumentando a renda dos produtores sem que este fator influencie no preço para nossos clientes.  
          </p>
          </div>
      
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
.sobree{
  text-align: justify;
  font-size: 25px;
}
.fundobranco{
    background-color: rgba(255, 255, 255, 0.7);
    border-radius: 10px;
    padding: 5px;
}
</style>