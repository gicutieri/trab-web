<template>
  <div class="footer">
    <footer>
      <div class="footer-top">
        <div class="container">
          <div class="row">
            <div class="col-md-3 footer-about">
              <img class="logo-footer" src="@/assets/Header/LogoYBY.svg" alt="logo-footer">
                <p>
                  Plantamos bondade para colher felicidade.
                </p>
                <p><a href="#">NOSSO TIME</a></p>
                </div>
                <div class="col-md-4 offset-md-1 footer-contact wow fadeInDown">
                  <h3>Contato</h3>
                  <p><i class="fas fa-map-marker-alt"></i> Sede: São Carlos</p>
                  <p><i class="fas fa-phone"></i> TELEFONE 0800 123 456</p>
                  <p><i class="fas fa-envelope"></i> EMAIL: <a href="mailto:sac@yby.com">sac@yby.com</a></p>
                </div>
                <div class="col-md-4 footer-links wow fadeInUp">
                  <div class="row">
                    <div class="col">
                      <h3>Links</h3>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-6">
                      <p><a class="scroll-link" href="#top-content">HOME</a></p>
                      <p><a href="#">LOJA</a></p>
                      <p><a href="#">SOBRE</a></p>
                      <p><a href="#">CARRINHO</a></p>
                    </div>
                    <div class="col-md-6">
                      <p><a href="#">MINHA CONTA</a></p>
                      <p><a href="#">LOGIN</a></p>
                      <p><a href="#">LOGOUT</a></p>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
            <div class="footer-bottom">
              <div class="container">
                <div class="row">
                  <div class="col-md-12 footer-copyright">
                    &copy; Template made by Grupo 3
                  </div>
                </div>
              </div>
            </div>
          </footer>
        </div>
</template>

<script>
export default {
  name: 'Footer'
}
</script>

<style scoped>
 .footer{
    background: #325E47;
 }
 .dropdown-item {
    color: #AF7061;
}
 .footer-top { padding: 60px 0; background:#325E47; text-align: left; color: #aaa; font-family: 'Montserrat', sans-serif; }
.footer-top h3 { padding-bottom: 10px; color: #fff; }

.footer-about img.logo-footer { height: 150px; margin-top: 0; margin-bottom: 5px; }
.footer-about p a { border: 0; }
.footer-about p a:hover, .footer-about p a:focus { border: 0; }

.footer-contact p { word-wrap: break-word; }
.footer-contact i { padding-right: 10px; font-size: 18px; color:#325E47 }
.footer-contact p a { border: 0; }
.footer-contact p a:hover, .footer-contact p a:focus { border: 0; }

.footer-links a { color: #aaa; border: 0; }
.footer-links a:hover, .footer-links a:focus { color: #fff; }

.footer-bottom { padding: 15px 0 17px 0; background:#193627; text-align: left; color: #aaa; }

.footer-social { padding-top: 3px; text-align: right; }
.footer-social a { margin-left: 20px; color: #777; border: 0; }
.footer-social a:hover, .footer-social a:focus { color: #79a05f; border: 0; }
.footer-social i { font-size: 24px; vertical-align: middle; }

.footer-copyright { padding-top: 5px; }
</style>