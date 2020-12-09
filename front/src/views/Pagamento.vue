<template>
    <div class="pagamento">
        <div class="container">
            
            <div class="row">
                <div class="shape">
                    <h2 class="shapecontent">FINALIZANDO COMPRA</h2>
                </div>
            </div>


            <form name="pagamento" class="form-horizontal" method="POST" onsubmit="event.preventDefault();">

                <div class="fundobranco">
                    <fieldset>
                        <legend>CONFIRME LOCAL DE ENTREGA</legend>

                        <div v-for="(local,index) in enderecos" :key="index" class="form-group">
                            <input type="radio" v-bind:id="key" v-bind:value="key" name="Entrega"  class="tx" required/>
                            <label v-bind:for="key">{{ local.Cidade +", "+ local.rua +" "+ local.Num +" "+ local.Complemento }}</label>
                        </div>
                    </fieldset>
                </div>
                
                <hr class="my-4">

                <div class="fundobranco">
                    <fieldset>
                        <legend>DADOS DE PAGAMENTO</legend>
                        <p class="controlf">FORMA DE PAGAMENTO*</p>
                            <div class="form-row">
                                <div class="form-check form-check-inline tx">
                                    <input id="dinheiro" type="radio" name="forma_pagamento" class="form-check-input" value="dinheiro" required/>
                                    <label for="dinheiro" class="form-check-label tx">Dinheiro</label>
                                </div>
                                <div class="form-check form-check-inline tx">
                                    <input id="cartao" type="radio" name="forma_pagamento" class="form-check-input" value="cartao" required/>
                                    <label for="cartao" class="form-check-label tx">Cartão</label>
                                </div>
                            </div>
                    </fieldset>
                </div>
                
                <hr class="my-4">

                <div id="outer">
                    <div class="row">
                        <div class="col-md-6 col-2">
                            <input type="reset" value="Limpar" class="btn btn-secondary btn-lg btncad btn-block btn-outline-light">
                        </div>
                        <div class="col-md-6 col-2">
                            <input type="submit" value="Confirmar" class="btn btn-secondary btn-lg btncad btn-block btn-outline-light" onclick="verificarCadastro()">
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</template>

<script>

export default {
    name: 'Pagamento',
    data: function() {
        return{
            enderecos: [
                {index: 0, rua: "Rua Jacinto Favoretto", Num: "0", Complemento: "", Cidade: "São Carlos"}, 
                {index: 1, rua: "Rua Luiz Vaz de Toledo Piza", Num: "0", Complemento: "Bloco 2, Apto 223", Cidade: "São Carlos"}
            ]
        }
        
    },
}

</script>

<style scoped>
.fundobranco{
    background-color: rgba(255, 255, 255, 0.7);
    border-radius: 10px;
    padding: 5px;
}
.container{
    padding: 10px;
}
legend{
    color: #AF7061;
    padding-left: 5px;
    background-color:#385f47;
}
label{
    padding-left: 5px;
    color: #385f47;
    font-size: 20px;
}
.tx{
    padding-left: 5px;
}
.controlf{
    padding-left: 5px;
    color: #385f47;
    font-size: 20px;
}
</style>
