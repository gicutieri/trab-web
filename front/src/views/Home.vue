<template>
  <div class="home">
    <Carousel/>

    <div class="container">
      <div class="row">
        <div class="col-sm-6 marcado py-4">
          <h2>Destaques</h2>
        </div>
      </div>

      <div class="row">
        <div class="col-sm-3">
          <div class="card">
            <img src="@/assets/Home/abacate.jpg" class="card-img-top" alt="..." />
              <div class="card-body">
                <h3 class="card-title">Abacate</h3>
                <h5>R$3,00</h5>
              </div>
              <button>Adicionar ao Carrinho</button>
          </div>
        </div>

        <div class="col-sm-3">
          <div class="card">
            <img src="@/assets/Home/abacate.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
              <h3 class="card-title">Abacate</h3>
              <h5>R$3,00</h5>
            </div>
            <button>Adicionar ao Carrinho</button>
          </div>
        </div>

        <div class="col-sm-3">
          <div class="card">
            <img src="@/assets/Home/abacate.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
              <h3 class="card-title">Abacate</h3>
              <h5>R$3,00</h5>
            </div>
            <button>Adicionar ao Carrinho</button>
          </div>
        </div>

        <div class="col-sm-3">
          <div class="card">
            <img src="@/assets/Home/abacate.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
              <h3 class="card-title">Abacate</h3>
              <h5>R$3,00</h5>
            </div>
            <button>Adicionar ao Carrinho</button>
          </div>
        </div>
      </div>

      <div class="row">
        <div class="col-sm-6 marcado py-4">
          <h2>Origem</h2>
        </div>
      </div>

      <div class="row">
        <div class="col-lg-12 py-5">
          <img src="@/assets/Home/diagrama-cortado-removebg-preview.png" alt="diagrama da origem de nossos produtos, mostrando o caminho do produtor, transporte, canal de distribui��o e a chegada ao cliente." class="mximg-responsive center-block d-block mx-auto">
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
import Carousel from '@/components/Carousel.vue'

export default {
  name: 'Home',
  components: {
    Carousel
  }
}
</script>

<style scoped>

</style>