///<reference path="jquery.validate.js"/>
///<reference path="jquery.validate.unobtrusive.js"/>
debugger;
if ($.validator && $.validator.unobtrusive) {

//definimos el adaptador
    $.validator.unobtrusive.adapters.addSingleVal("maxwords", "wordcount");

//agregamos la funcion
    $.validator.addMethod("maxwords",
        function(value, element, wordcount) {
            debugger;
            if (value) {
                if (value.split(" ").length > wordcount) {
                    return false;
                }
            }
            return true;
        }
    );
}