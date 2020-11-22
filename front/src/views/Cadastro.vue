<template>
  <div class="cadastro">
    <div class="container">
        <div class="row">
            <div class="col-sm-6 marcado py-4">
                <h2>Cadastro</h2>
            </div>
        </div>

        <form name="cadastro" class="form-horizontal" method="POST" onsubmit="event.preventDefault();">

            <fieldset>
                <legend>Dados Pessoais</legend>
                
                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="nome">Nome *</label>
                    <div class="col-md-9">
                        <input id="nome" type="text" name="user_nome" class="form-control input-md" size="80" required/>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="cpf">CPF *</label>
                    <div class="col-md-4">
                        <input id="cpf" type="text" name="user_cpf" placeholder="Ex.: 000.000.000-00" maxlength="14" class="form-control input-md" pattern="[0-9]{2-3}.[0-9]{3}.[0-9]{3}-[0-9]{2}" onBlur="showhide()" required/>
                    </div>

                    <label class="col-md-2 control-label" for="rg">RG *</label>
                    <div class="col-md-3">
                        <input id="rg" type="text" name="user_rg" placeholder="Ex.: 00.000.000-0" maxlength="12" class="form-control input-md" onBlur="showhide()" required/>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="tel">Telefone *</label>
                    <div class="col-md-4">
                        <div>
                            <input id="tel" type="tel" name="user_tel" placeholder="Ex.: 00 00000-0000" maxlength="15" class="form-control" pattern="[0-9]{2} [0-9]{4-5}-[0-9]{4}" onBlur="showhide()" required/>
                            <!--span class="input-group-addon"><i class="fa fa-phone"></i></span-->
                        </div>
                    </div>

                    <label class="col-md-2 control-label" for="Nascimento">Nascimento *</label>  
                    <div class="col-md-3">
                        <input id="Nascimento" type="date" name="user_Nascimento" class="form-control input-md" onBlur="showhide()" required/>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="email">Email *</label>  
                    <div class="col-md-8">
                        <div>
                            <input id="email" type="email" name="user_email" class="form-control input-md" size="50" required/>
                            <!--span class="input-group-addon"><i class="fa fa-envelope"></i></span-->
                        </div>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="emailConf">Confirmar Email *</label>  
                    <div class="col-md-8">
                        <div>
                            <input id="email2" type="email" name="user_email2" class="form-control input-md" size="50" required/>
                            <!--span class="input-group-addon"><i class="fa fa-envelope"></i></span-->
                        </div>
                    </div>
                </div>
            </fieldset>

            <fieldset>
                <legend>Endere�o de Entrega</legend>
                
                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="rua">Endere�o *</label>
                    <div class="col-md-8">
                        <input id="rua" type="text" name="user_rua" class="form-control input-md" size="80" required/>
                    </div>
                </div>
                    
                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="n">N�mero *</label>
                    <div class="col-md-4">
                        <input id="n" type="number" name="user_n" class="form-control input-md" required/>
                    </div>

                    <label class="col-md-2 control-label" for="compl">Complemento</label>
                    <div class="col-md-3">
                        <input id="compl" type="text" name="user_compl" class="form-control input-md"/>
                    </div>
                </div>
                
                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="cidade">Cidade *</label>
                    <div class="col-md-4">
                        <input id="cidade" type="text" name="user_cidade" class="form-control input-md" required/>
                    </div>

                    <label class="col-md-2 control-label" for="bairro">Bairro *</label>
                    <div class="col-md-3">
                        <input id="bairro" type="text" name="user_bairro" class="form-control input-md" required/>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="est">Estado *</label>
                    <div class="col-md-4">
                        <input id="est" type="text" name="user_est" maxlength="2" class="form-control input-md" required/>
                    </div>

                    <label class="col-md-2 control-label" for="cep">CEP *</label>
                    <div class="col-md-3">
                        <input id="cep" type="text" name="user_cep" class="form-control input-md" placeholder="Ex.: 00000-000" maxlength="9" pattern="[0-9]{5}-[0-9]{3}" onBlur="showhide()" required/>
                    </div>
                </div>
            </fieldset>

            <fieldset>
                <legend><br>Dados de Login<br></legend>
            
                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="usuario">Nome de Usu�rio *</label>
                    <div class="col-md-4">
                        <input id="usuario" type="text" name="user_usuario" class="form-control input-md" required/>
                    </div>

                    <label class="col-md-2 control-label" for="senha">Senha *</label>
                    <div class="col-md-3">
                        <input id="senha" type="password" name="user_senha" class="form-control input-md" required/>
                    </div>
                </div>

                <div class="form-group form-inline">
                    <label class="col-md-2 control-label" for="usuario2">Confirmar Usu�rio *</label>
                    <div class="col-md-4">
                        <input id="usuario2" type="text" name="user_usuario2" class="form-control input-md" required/>
                    </div>

                    <label class="col-md-2 control-label" for="senha2">Confirmar Senha *</label>
                    <div class="col-md-3">
                        <input id="senha2" type="password" name="user_senha2" class="form-control input-md" required/>
                    </div>
                </div>
            </fieldset>

            <div id="outer">
                <div class="p-2 nav-item">
                    <input type="reset" value="Limpar" class="btn btn-outline-light">
                </div>

                <div class="p-2 nav-item">
                    <input type="submit" value="Confirmar" class="btn btn-outline-light" onclick="verificarCadastro()">
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

</style>