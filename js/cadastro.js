/*
Introdução ao Desenvolvimento Web
Grupo 3 - Hortifruti

Alunos:
Giovanna Gonçalves Cutieri - 10295197
Pedro Ramos Cunha - 10892248
André Gustavo Jucovski - 9783272
Armando Akio Morey Filho - 8485632
Yan Crisostomo Rohwedder - 9779263
*/

function verificarCadastro(){

	var nome = cadastro.user_nome.value;
	var cpf = cadastro.user_cpf.value;
	var rg = cadastro.user_rg.value;
	var tel = cadastro.user_tel.value;
	var nascimento = cadastro.user_Nascimento.value;
	var email = cadastro.user_email.value;
	var email2 = cadastro.user_email2.value;

	var rua = cadastro.user_rua.value;
	var n = cadastro.user_n.value;
	var cidade = cadastro.user_cidade.value;
	var bairro = cadastro.user_bairro.value;
	var est = cadastro.user_est.value;
	var cep = cadastro.user_cep.value;

	var usuario = cadastro.user_usuario.value;
	var usuario2 = cadastro.user_usuario2.value;
	var senha = cadastro.user_senha.value;
	var senha2 = cadastro.user_senha2.value;


	if(	nome=='' || cpf=='' || rg=='' || tel=='' || nascimento=='' || email=='' || email2=='' || 
		rua=='' || n=='' || cidade=='' || bairro=='' || est=='' || cep=='' || 
		usuario=='' || usuario2=='' || senha=='' || senha2==''){

		alert("Preencha todos os campos com *");
		return false;
	}

	if(email != email2){
		alert("E-mails são diferentes!");
		return false;
	}

	if(usuario != usuario2){
		alert("Nomes de usuário são diferentes!");
		return false;
	}

	if(senha != senha2){
		alert("Senhas são diferentes!");
		return false;
	}


	window.location.replace("/cliente.html");
	
}



//-----------------------------------------------------------------------------



function mascara(entrada, formato){
    v_entrada = entrada
    v_formato = formato
    setTimeout("execmascara()",1)
}

function execmascara(){
    v_entrada.value = v_formato(v_entrada.value)
}

function telefone(v){
    v=v.replace(/\D/g,"")
    v=v.replace(/^(\d\d)(\d)/g,"$1 $2")
	v=v.replace(/(\d{5})(\d)/,"$1-$2")
    return v
}

function cpf(v){
    v=v.replace(/\D/g,"")
    v=v.replace(/^(\d{3})(\d)/g,"$1.$2")
    v=v.replace(/(\d{3})(\d)/g,"$1.$2")
    v=v.replace(/(\d{3})(\d{1,2})$/,"$1-$2")
    return v
}

function rg(v){
    v=v.replace(/[^\dX]/g,"")
    v=v.replace(/^(\d{1,2})(\d{3})(\d{3})(\dX)$/,"$1.$2.$3-$4")
    return v
}

function cep(v){
    v=v.replace(/\D/g,"")
    v=v.replace(/^(\d{5})(\d)/,"$1-$2")
    return v
}

function data(v){
    v=v.replace(/\D/g,"")
    v=v.replace(/^(\d{2})(\d)/,"$1/$2")
	v=v.replace(/(\d{2})(\d{4})/,"$1/$2")
    return v
}