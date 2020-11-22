<template>
  <div id="app">
    <Header/>
    <router-view class="app"/>
    <Footer/>
  </div>
</template>

<script>
import Header from "@/components/Header";
import Footer from "@/components/Footer";

export default {
  name: "App",
  components: {
    Header,
    Footer
  }
};
</script>
  
<style>
  .app {
    font-family: 'Montserrat', sans-serif;
    background-image: url("~@/assets/Body/Background.svg");
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    min-height: 1125px;
  }
</style>