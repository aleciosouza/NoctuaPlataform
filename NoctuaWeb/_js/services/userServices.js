$(document).ready(function () {

    /*Elementos do formulário*/
    var nome = $('#tfNome');
    var sobrenome = $('#tfSobrenome');
    var dtNasc = $('#tfDtNasc');
    var email = $('#tfEmail');
    var password = $('#tfPassword');
    var passwordConf = $('#tfPasswordConf');


    $('#btSalvar').click(function () {

        //Verifica se os dados são válidos
        if (validaUserForm()) {

            var user = {
                nome: nome.val(),
                sobrenome: sobrenome.val(),
                dtNasc: dtNasc.val(),
                email: email.val(),
                password: password.val()
            };

            console.log("Nome: " + user.nome +
                "\nSobrenome: " + user.sobrenome +
                "\ndtnasc: " + user.dtNasc +
                "\nemail: " + user.email +
                "\npassword: " + user.password);


            insertUser(user);
        }

    });

});