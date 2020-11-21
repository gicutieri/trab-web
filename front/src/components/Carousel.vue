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
      @sliding-start="onSlideStart"
      @sliding-end="onSlideEnd"
    >
      <b-carousel-slide img-src="@/assets/Carousel/Home1.png">
        <h1>PRODUÇÃO FAMILIAR</h1>
      </b-carousel-slide>
      <b-carousel-slide img-src="@/assets/Carousel/Home2.png">
        <h1>COLHIDOS COM AMOR</h1>
      </b-carousel-slide>
      <b-carousel-slide img-src="@/assets/Carousel/Home3.png">
        <h1>HIGIENIZADOS</h1>
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
  div.carousel-caption *{
    color:white;
    background: rgba(70, 38, 38, 0.651);
    max-width: max-content;
    font-size: 4vw;
  }
</style>