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
    background-attachment: fixed;
    background-repeat: repeat-y;
    background-size: cover;
    min-height: 1125px;
    background-color: #819476;
  }
  .shape{
    background-color:#96744F;
    width:100%;
    height:60px;
    position:relative;
    margin: 10px;
  }
  .shapecontent{
    color: #385F47;
    font-size: 4vh;
    margin:auto;
    line-height:60px;
    position: relative;
    text-align:center;
  }

  .searchbar{
    padding-top: 10px;
    padding-bottom: 10px;
  }
  .inline-block-child{
    display: inline-block;
  }
  .but{
    padding-top: 10px;
  }
  .carousel-caption h3{
    color:white;
    background: rgba(70, 38, 38, 0.651);
    font-size: 4vw;
    margin-right: 7%;
    margin-left: 7%;
  }
  .carback{
  background-color: rgba(255, 255, 255, 0.7);
  /*border: 1px solid black;*/ 
  border-radius: 10px;
  margin-top: 5px;
  padding-right: 5px;
  padding-left: 5px;
  padding-bottom: 10px;
}
.dropdown-menu.show {
    display: block;
    background-color: #325E47;
}
a.dropdown-item {
    color: #AF7061;
    font-size: 20px;
}
</style>