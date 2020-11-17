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

function validar(){
	var username = login.user_username.value;
	var password = login.user_password.value;

	if(username=='' || password==''){
		alert('Campos vazios.');
		return false;
	}
	
	window.location.replace("/cliente.html");

}