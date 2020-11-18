<template>
  <div class="header">
    <header>
      <div class="navbar navbar-dark bg-fundo-escuro shadow-sm">
        <div class="container d-flex justify-content-between">
          <router-link id="logo" class="navbar-brand d-flex align-items-center" :to="{ name: 'Home' }">
            <strong>Hortifruti</strong>
          </router-link>
        </div>
      </div>

      <nav class=" navbar navbar-expand navbar-light bg-fundo-escuro">
        <div class="container">
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>

          <div class="collapse navbar-collapse navbar-custom" id="navbarNav">
            <ul class="navbar-nav">
              <li class="nav-item">                
                <router-link
                  class="nav-link"
                  active-class="active"
                  exact
                  :to="{ name: 'Home' }">
                  Home</router-link>
              </li>
              <li class="nav-item">
                <router-link
                  class="nav-link"
                  active-class="active"
                  exact
                  :to="{ name: 'Loja' }">
                  Loja</router-link>
              </li>
              <li class="nav-item">
                <router-link
                  class="nav-link"
                  active-class="active"
                  exact
                  :to="{ name: 'Sobre' }">
                  Sobre</router-link>
              </li>
              <li class="nav-item">
                <router-link
                  class="nav-link"
                  active-class="active"
                  exact
                  :to="{ name: 'Carrinho' }">
                  Carrinho</router-link>
              </li>
            </ul>

            <ul class="navbar-nav ml-auto">
              <li class="p-2 nav-item">
                <a class="btn btn-sm btn-outline-light" href="/cadastro.html">SIGN UP</a>
              </li>
              <li class="p-2 nav-item">
                <div class="dropdown">
                  <button class="btn btn-sm btn-outline-light btn-primary dropdown-toggle" type="button" data-toggle="dropdown">LOGIN
                    <span class="caret"></span></button>

                  <form name="login" class="dropdown-menu" method="POST">
                    <input id="user_username" name="user_username" type="text" placeholder="Nome"/>
                    <input id="user_password" name="user_password" type="password" placeholder="Senha"/>
                    <input id="user_remember" name="user_remember" type="checkbox" value="1"/>
                      <label class="string optional" for="user_remember" style="color: white; font-size: 14px; position: relative; bottom: 6px;"> Remember me</label>

                    <input id="login_button" type="submit" value="SIGN IN" onclick="validar()">
                  </form>
                </div>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </header>
  </div>
</template>

<script>
export default {
  name: 'Header'
}
</script>

<style scoped>

</style>