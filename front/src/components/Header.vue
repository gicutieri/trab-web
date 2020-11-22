<template>
  <header>
    <div>
      <b-navbar toggleable="lg">
        <b-navbar-brand href="#"><img src="@/assets/Header/LogoYBY.svg" class="img-logo" alt=""></b-navbar-brand>

        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

        <b-collapse id="nav-collapse" is-nav>
          <!-- Right aligned nav items -->
          <b-navbar-nav class="ml-auto">
            <b-navbar-nav>
              <b-nav-item :to="{ name: 'Home' }">HOME</b-nav-item>
              <b-nav-item :to="{ name: 'Loja' }">LOJA</b-nav-item>
              <b-nav-item :to="{ name: 'Sobre' }">SOBRE</b-nav-item>
              <b-nav-item :to="{ name: 'Carrinho' }">CARRINHO</b-nav-item>
            </b-navbar-nav>

            <b-nav-item-dropdown right>
              <!-- Using 'button-content' slot -->
              <template #button-content>
                <img src="@/assets/Header/signvec.svg" alt="">
              </template>
              <b-dropdown-item :to="{name : 'Cadastro'}">Profile</b-dropdown-item>
              <b-dropdown-item href="#">Sign Out</b-dropdown-item>
            </b-nav-item-dropdown>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </div>
  </header>
</template>

<script>
import { 
    BNavbar, BNavbarBrand,
    BNavbarToggle, BCollapse, 
    BNavbarNav, BNavItem, 
    BNavItemDropdown, BDropdownItem 
  } from 'bootstrap-vue'

export default {
  name: 'Header',
  components: {
    'b-navbar': BNavbar,
    'b-navbar-brand': BNavbarBrand,
    'b-navbar-toggle': BNavbarToggle,
    'b-collapse': BCollapse,
    'b-navbar-nav': BNavbarNav,
    'b-nav-item': BNavItem,
    'b-nav-item-dropdown': BNavItemDropdown,
    'b-dropdown-item': BDropdownItem
  }
}
</script>

<style scoped>
  .nav-item{
    font-size: 20px;
    font-family: 'Montserrat', sans-serif;
  }
  .navbar-nav .nav-link {
    color: #AF7061;
  }
  .nav-item-dropdown {
    color: #AF7061;
  }
  .navbar-light{
    background: #325E47;
    color: #AF7061;
  }
  .img-logo{
    height: 50px;
    padding-bottom: 0;
    padding-top: 0;
  }
  .navbar-brand {
    display: inline-block;
    max-width:50px;
    padding-top: 0;
    padding-bottom: 0;
    margin-right: 1rem;
    font-size: 1.25rem;
    line-height: inherit;
    white-space: nowrap;
  }
  @media (min-width: 992px) {
    .navbar li {
      margin-left : 1em;
      margin-right : 1em;
    }
  }
</style>