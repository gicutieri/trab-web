<template>
  <div class="carrinho">
    <div class="container">
      <div class="row">
        <div class="col-md-8">
          <div class="marcado py-4">
            <h2>Meu Carrinho</h2>
          </div>
          <div class="container cart">

            <div class="row">
              <div class="col-sm-4"><img src="/imagens/abacate.jpg" class="card-img-top" alt="foto do produto" />
              </div>
              <div class="container col-sm-8">
                <div class="row">
                  <div class="col-sm-6">Abacate</div>
                  <div class="col-sm-4">$20.00</div>
                  <div class="col-sm-2">X</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">$5.00</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">
                    <span class="align-middle" style="border: 1px solid #ccc!important; border-color: #b4b9b9!important;">- 4 +</span>
                  </div>
                </div>
              </div>
            </div>

            <hr class="my-4">

            <div class="row">
              <div class="col-sm-4"><img src="/imagens/abacate.jpg" class="card-img-top" alt="foto do produto" />
              </div>
              <div class="container col-sm-8">
                <div class="row">
                  <div class="col-sm-6">Abacate</div>
                  <div class="col-sm-4">$20.00</div>
                  <div class="col-sm-2">X</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">$5.00</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">
                    <span class="align-middle" style="border: 1px solid #ccc!important; border-color: #b4b9b9!important;">- 4 +</span>
                  </div>
                </div>
              </div>
            </div>

            <hr class="my-4">

            <div class="row">
              <div class="col-sm-4"><img src="/imagens/abacate.jpg" class="card-img-top" alt="foto do produto" />
              </div>
              <div class="container col-sm-8">
                <div class="row">
                  <div class="col-sm-6">Abacate</div>
                  <div class="col-sm-4">$20.00</div>
                  <div class="col-sm-2">X</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">$5.00</div>
                </div>
                <div class="row">
                  <div class="col-sm-12">
                    <span class="align-middle" style="border: 1px solid #ccc!important; border-color: #b4b9b9!important;">- 4 +</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="col-md-4">
          <div class="marcado py-4">
            <h2>Resumo</h2>
          </div>
          <div class="container cart">
            <div class="row">
              <div class="col-sm-6">Sub-Total</div>
              <div class="col-sm-6 text-lg-right">$30.00</div>
            </div>
            <div class="row">
              <div class="col-sm-6">Envio</div>
              <div class="col-sm-6 text-lg-right">Gr�tis</div>
            </div>
            <div class="row">
              <div class="col-sm-12">S�o Carlos, Brasil</div>
            </div>

            <hr class="my-4">

            <div class="row">
              <div class="col-sm-6">Total</div>
              <div class="col-sm-6 text-lg-right">$30.00</div>
            </div>
            <div class="row justify-content-md-center">
              <div class="col-sm-12">
                <button id="finalizar" type="button" class="btn btn-secondary btn-lg btn-block btn-outline-light">Finalizar Compra</button>
              </div>
            </div>
          </div>
        </div>
      </div> <!-- <div class="row"> -->
    </div> <!-- <div class="container"> -->
  </div>

</template>

<script>

export default {
  name: 'Carrinho'
}
</script>

<style scoped>

</style>