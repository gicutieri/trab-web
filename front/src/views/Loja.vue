<template>
  <div class="loja">
    <div class="container">
      <div class="marcado py-4 search-bar">
        <div class="row">
          <input class="text-line search-bar" type="text" placeholder="search">
          <button class="searchbar-button"><span><i class="fa fa-search"></i></span></button>
        </div>
      </div>

      <div class="row">
        <Card/>
        <Card/>
        <Card/>
        <Card/>
      </div>

      <div class="row">
        <Card/>
        <Card/>
        <Card/>
        <Card/>
      </div>

      <div id="buttons">
        <button class="btn btn-md btn-outline-light" style="margin-right: 2%;">
          <span><i class="fa fa-arrow-left"></i></span>
        </button>

        <button class="btn btn-md btn-outline-light"> 1 </button>

        <button class="btn btn-md btn-outline-light" style="margin-left: 2%;">
          <span><i class="fa fa-arrow-right"></i></span>
        </button>
      </div>

    </div> <!-- <div class="container"> -->
  </div> <!-- <div class="loja"> -->
</template>

<script>
import Card from '@/components/Card.vue'

export default {
  name: 'Loja',
  components: {
    Card
  }
}
</script>

<style scoped>

</style>