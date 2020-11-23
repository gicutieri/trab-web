<template>
  <div class="cadastro">
    <div class="container">

    <div class="row">
        <div class="shape">
            <h2 class="shapecontent">Escolha a forma de pagamento</h2>
        </div>
    </div>


        <form name="pagamento" class="form-horizontal" method="POST" onsubmit="event.preventDefault();">

            <fieldset>
                <legend>DADOS PESSOAIS</legend>

                <div class="form-group">
                    <label class="control-label" for="nome">NOME*</label>
                    <input type="text" id="nome" class="form-control" size="80" name="user_nome" required>
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
                    <input id="email" type="email" name="user_email" class="form-control"  required/>
                </div>

                <div class="form-group">
                    <label class="control-label" for="emailConf">CONFIRMAR EMAIL*</label>  
                    <input id="email2" type="email" name="user_email2" class="form-control" size="50" required/>
                </div>

            </fieldset>
            <hr class="my-4">
            <fieldset>
                <legend>DADOS DE ENTREGA</legend>
                
                <div class="form-group">
                    <label for="rua" class="control-label">ENDEREÇO*</label>
                    <input id="rua" type="text" name="user_rua" class="form-control"  required/>
                </div>

                <div class="form-row">
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="n">NÚMERO*</label>
                        <input id="n" type="number" name="user_n" class="form-control" required/>
                    </div>
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="compl">COMPLEMENTO*</label>
                        <input id="compl" type="text" name="user_compl" class="form-control" required/>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="cidade">CIDADE*</label>
                        <input id="cidade" type="text" name="user_cidade" class="form-control" required/>
                    </div>
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="bairro">BAIRRO*</label>
                        <input id="bairro" type="text" name="user_bairro" class="form-control" required/>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="est">ESTADO*</label>
                        <input id="est" type="text" name="user_est"  maxlength="2" class="form-control" required/>
                    </div>
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="cep">CEP*</label>
                        <input id="cep" type="text" name="user_cep" class="form-control" placeholder="Ex.: 00000-000" maxlength="9" pattern="[0-9]{5}-[0-9]{3}" onBlur="showhide()" required/>
                    </div>
                </div>
            </fieldset>
            <hr class="my-4">

            <fieldset>
                <legend>DADOS DE LOGIN</legend>
                <div class="form-row">
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="usuario">NOME DE USUÁRIO*</label>
                        <input id="usuario" type="text" name="user_usuario"  class="form-control" required/>
                    </div>
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="senha">SENHA*</label>
                        <input id="senha" type="password" name="user_senha"  class="form-control" required/>
                    </div>
                </div>

                <div class="form-row">
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="usuario2">CONFIRMAR NOME DE USUÁRIO*</label>
                        <input id="usuario2" type="text" name="user_usuario2"  class="form-control" required/>
                    </div>
                    <div class="col-md-6 form-group">
                        <label class="control-label" for="senha2">CONFIRMAR SENHA*</label>
                        <input id="senha2" type="password" name="user_senha2"  class="form-control" required/>
                    </div>
                </div>
            </fieldset>

            <div id="outer">
                <div class="row">
                    <div class="col-md-6 col-2">
                        <input type="reset" value="Limpar" class="btn btn-outline-light">
                    </div>
                    <div class="col-md-6 col-2">
                        <input type="submit" value="Confirmar" class="btn btn-outline-light" onclick="verificarCadastro()">
                    </div>
                </div>
            </div>
        </form>
    </div>
  </div>
</template>