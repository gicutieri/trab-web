<template>
    <div class="minha-conta">
        <div class="container">
            <div class="row">
                <div class="shape">
                    <h2 class="shapecontent">MINHA CONTA</h2>
                </div>
            </div>
            <div name="dados">

                <div class="fundobranco">
                    <fieldset>
                        <legend>DADOS PESSOAIS</legend>
                        <div class="col-md-12">
                            <label for="nome">NOME</label>
                            <p id="nome">Nome Completo da Pessoa</p>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="cpf">CPF</label>
                                    <p id="cpf">000.000.000-00</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="rg">RG</label>
                                    <p id="rg">00.000.000-0</p>
                                </div>
                            </div>
                        </div>
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="tel">TELEFONE*</label>
                                    <p id="tel">00 00000-0000</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="Nascimento">NASCIMENTO</label>
                                    <p id="Nascimento">00/00/0000</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <label for="email">EMAIL</label>
                                <p id="email">email@email.com</p>
                        </div>
                    </fieldset>
                </div>

                <hr class="my-4">

                <div class="fundobranco">
                    <fieldset>
                        <legend>DADOS DE ENTREGA</legend>

                        <div class="col-md-6">
                            <label for="rua">ENDEREÇO</label>
                            <p id="rua">Nome da Rua</p>
                        </div>

                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="n">NÚMERO</label>
                                    <p id="n">000</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="compl">COMPLEMENTO</label>
                                    <p id="compl">A</p>
                                </div>
                            </div>
                        </div>

                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="cidade">CIDADE</label>
                                    <p id="cidade">Cidade</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="bairro">BAIRRO</label>
                                    <p id="bairro">Bairro</p>
                                </div>
                            </div>
                        </div>

                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="est">ESTADO</label>
                                    <p id="est">SP</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="cep">CEP</label>
                                    <p id="cep">00000-000</p>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                </div>

                <hr class="my-4">

                <div class="fundobranco">
                    <fieldset>
                        <legend>DADOS DE LOGIN</legend>

                        <div class="container">
                            <div class="row">
                                <div class="col-md-6">
                                    <label for="usuario">NOME DE USUÁRIO</label>
                                    <p id="usuario">username</p>
                                </div>
                                <div class="col-md-6">
                                    <label for="senha">SENHA</label>
                                    <p id="senha"><u>Alterar senha</u></p>
                                </div>
                            </div>
                        </div>

                    </fieldset>
                </div>

                <hr class="my-4">

                <div class="fundobranco" >
                    <fieldset>
                        <legend>HISTÓRICO</legend>

                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="container">
                                        <div class="row">
                                            <p class="col-md-4">23/11/2020</p>
                                            <p class="col-md-4"><u>Ver produtos</u></p>
                                            <p class="col-md-4"><span class="pull-right">Total: R$00,00</span></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </fieldset>           
                </div>    
            </div> <!--div dados-->
        </div>
    </div>
</template>

<script>

export default {
  name: 'Minha-conta'
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
p{
    padding-left: 5px;
    font-size: 15px;
    background-color: whitesmoke;
}
</style>