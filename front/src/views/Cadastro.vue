<template>
  <div class="cadastro">
    <div class="container">

    <div class="row">
        <div class="shape">
            <h2 class="shapecontent">CADASTRO</h2>
        </div>
    </div>


        <form name="cadastro" class="form-horizontal" method="POST" onsubmit="event.preventDefault();">
            <div class="fundobranco">
                <fieldset>
                    <legend>DADOS PESSOAIS</legend>

                    <div class="form-group">
                        <label class="control-label" for="nome">NOME*</label>
                        <input type="text" id="nome" class="form-control" size="80" name="user_nome" placeholder="Ex.: FULANO DA SILVA PINTO" required>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="cpf">CPF*</label>
                            <input id="cpf" type="text" name="user_cpf" placeholder="Ex.: 000.000.000-00" maxlength="14" class="form-control" pattern="[0-9]{2-3}.[0-9]{3}.[0-9]{3}-[0-9]{2}" onBlur="showhide()" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label for="rg" class="control-label">RG*</label>
                            <input id="rg" type="text" name="user_rg" placeholder="Ex.: 00.000.000-0" maxlength="14" class="form-control" pattern="[0-9]{2-3}.[0-9]{3}.[0-9]{3}-[0-9]{2}" onBlur="showhide()" required/>
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="tel">TELEFONE*</label>
                            <input id="tel" type="tel" name="user_tel" placeholder="Ex.: 00 00000-0000" maxlength="15" class="form-control" pattern="[0-9]{2} [0-9]{4-5}-[0-9]{4}" onBlur="showhide()" required/>                    
                        </div>
                        <div class="col-md-6 form-group">
                            <label for="Nascimento" class="control-label">NASCIMENTO*</label>
                            <input id="Nascimento" type="date" name="user_Nascimento" class="form-control" onBlur="showhide()" required/>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label" for="email">EMAIL*</label>
                        <input id="email" type="email" name="user_email"  placeholder="Ex.: fulanolindo97@hotmail.com" class="form-control"  required/>
                    </div>

                    <div class="form-group">
                        <label class="control-label" for="emailConf">CONFIRMAR EMAIL*</label>  
                        <input id="email2" type="email" name="user_email2" placeholder="Ex.: fulanolindo97@hotmail.com"  class="form-control" size="50" required/>
                    </div>
                </fieldset>
            </div>

            <hr class="my-4">

            <div class="fundobranco">
                <fieldset>
                    <legend>DADOS DE ENTREGA</legend>
                    
                    <div class="form-group">
                        <label for="rua" class="control-label">ENDEREÇO*</label>
                        <input id="rua" type="text" placeholder="Ex.: Rua Professor Epicospal" name="user_rua" class="form-control"  required/>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="n">NÚMERO*</label>
                            <input id="n" type="number" name="user_n" placeholder="Ex.: 2870"  class="form-control" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="compl">COMPLEMENTO*</label>
                            <input id="compl" type="text" placeholder="Ex.: Apto 144" name="user_compl" class="form-control" required/>
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="cidade">CIDADE*</label>
                            <input id="cidade" type="text" name="user_cidade" placeholder="Ex.: Curitiba" class="form-control" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="bairro">BAIRRO*</label>
                            <input id="bairro" type="text" placeholder="Ex.: Centro" name="user_bairro" class="form-control" required/>
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="est">ESTADO*</label>
                            <input id="est" type="text" placeholder="Ex.: Paraná" name="user_est"  maxlength="2" class="form-control" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="cep">CEP*</label>
                            <input id="cep" type="text" name="user_cep" class="form-control" placeholder="Ex.: 00000-000" maxlength="9" pattern="[0-9]{5}-[0-9]{3}" onBlur="showhide()" required/>
                        </div>
                    </div>
                </fieldset>

            </div>

            <hr class="my-4">

            <div class="fundobranco">
                <fieldset>
                    <legend>DADOS DE LOGIN</legend>
                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="usuario">NOME DE USUÁRIO*</label>
                            <input id="usuario" type="text" placeholder="Ex.: FulanoTOP" name="user_usuario"  class="form-control" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="senha">SENHA*</label>
                            <input id="senha" type="password" placeholder="*******" name="user_senha"  class="form-control" required/>
                        </div>
                    </div>

                    <div class="form-row">
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="usuario2">CONFIRMAR NOME DE USUÁRIO*</label>
                            <input id="usuario2" type="text" placeholder="Ex.: FulanoTOP" name="user_usuario2"  class="form-control" required/>
                        </div>
                        <div class="col-md-6 form-group">
                            <label class="control-label" for="senha2">CONFIRMAR SENHA*</label>
                            <input id="senha2" type="password" placeholder="*******" name="user_senha2"  class="form-control" required/>
                        </div>
                    </div>
                </fieldset>
            </div>

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
  name: 'Cadastro'
}
</script>

<style scoped>
.container{
    padding: 10px;
}
.fundobranco{
    background-color: rgb(255, 255, 255);
    border-radius: 10px;
    padding: 5px;
}
legend{
    color: #AF7061;
    padding-left: 5px;
    background-color:#385f47;
}
label.control-label{
    padding-left: 5px;
    color: #385f47;
    font-size: 20px;
}
.btncad{
    margin-top: 5px;
}
</style>