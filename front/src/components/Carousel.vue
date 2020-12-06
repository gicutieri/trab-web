<template>
  <div>
     <b-carousel
      id="carousel-1"
      v-model="slide"
      :interval="4000"
      controls
      indicators
      background="#ababab"
      img-width="1024"
      img-height="200"
      style="    color:white;
    background: rgba(70, 38, 38, 0.651);
    font-size: 4vw;"
      @sliding-start="onSlideStart"
      @sliding-end="onSlideEnd"
    >
      <b-carousel-slide class="row-12" caption="PRODUÇÃO FAMILIAR" img-src="@/assets/Carousel/Home1.png">
      </b-carousel-slide>
      <b-carousel-slide  caption="COLHIDOS COM AMOR" img-src="@/assets/Carousel/Home2.png">
      </b-carousel-slide>
      <b-carousel-slide  caption="HIGIENIZADOS" img-src="@/assets/Carousel/Home3.png">
      </b-carousel-slide>
    </b-carousel> 
  </div>
</template>

<script>
export default {
  name: 'Carousel'
}
</script>
  
<style scoped>

</style>