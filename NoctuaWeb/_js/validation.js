/*Verifica se um elemento do formulário está vazio ou inválido*/
function check(element) {
        if (element.val() == "") {
            element.parent().addClass('is-invalid');
            return false;
        } else {
            if (element.parent().hasClass('is-invalid')) {
                element.parent().addClass('is-invalid');
                return false;
            }
        }

        return true;
    }

/*Verifica se um elemento do formulário está de acordo com a condição*/
function checkIf(element, cond) {
        if (cond) {
            return true;
        } else {
            element.parent().addClass('is-invalid');
            return false;
        }
    }