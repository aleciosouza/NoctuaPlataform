/*Verifica se o furmulário de cadastro de usuário é válido*/
function validaUserForm() {

    /*Elementos do formulário*/
    var nome = $('#tfNome');
    var sobrenome = $('#tfSobrenome');
    var dtNasc = $('#tfDtNasc');
    var email = $('#tfEmail');
    var password = $('#tfPassword');
    var passwordConf = $('#tfPasswordConf');
   

    return check(nome) &&
        check(sobrenome) &&
        check(dtNasc) &&
        check(email) &&
        check(password) &&
        checkIf(passwordConf, passwordConf.val() == password.val());    
}

function logChecks() {
    console.log("Nome: " + check(nome) +
        "\nSobrenome: " + check(sobrenome) +
        "\nData de nascimento: " + check(dtNasc) +
        "\nEmail: " + check(email) +
        "\nPassword: " + check(password) +
        "\nConfirmação de senha: " + checkIf(passwordConf, passwordConf.val() == password.val()));
}