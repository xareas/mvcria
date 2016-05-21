var addEventsGrid =(function($) {

    var urls = {
        controller: "Estudiante",
        actions: { edit: "Edit", delete: "Delete", view: "Details", create: "Create" }
    };

    $("#actionmenurow").css("display", "none");

    //boton de borrar
    $(".js-delete").on('click',function(evt) {
                //codigo del registro a borrar
                evt.preventDefault();
                var valor = $(this).attr('data-key');
                //titulo de la ventana emergente
                $('#myModal-label').html('Borrar Estudiante');
                //configuramos la llamada
                var url = urls.controller + '/' + urls.actions.delete;
                var request = $.get(url, { id: valor }, "html");

                request.done(function (data) {
                    $('#modalBody').html(data);
                    $('#myModal').modal('show');
                });

                request.fail(function(jqXHR, textStatus) {
                    $('#modalBody').html(jqXHR.responseText);
                    $('#myModal').modal('show');
                });

                request.always(function() {
                    //al finalizar
                });

               request.progress(function(evt) {
                   if (evt.lengthComputable) {
                       var percent = evt.loaded / evt.total;
                       console.log(percent);
                   }
               });
    });


    //boton de editar
    $('.js-edit').on('click', function (evt) {
                //prevenir la accion por defecto
                evt.preventDefault();
                //codigo del registro a modificar
                var valor = $(this).attr('data-key');
                $('#myModal-label').html('Editar Estudiante');
                var url = urls.controller + "/" + urls.actions.edit;
                var request = $.get(url, { id: valor }, "html");

                request.done(function(data) {
                    $('#modalBody').html(data);
                    $('#myModal').modal('show');
                });

                request.fail(function(jqXHR, textStatus) {
                    $('#modalBody').html(jqXHR.responseText);
                    $('#myModal').modal('show');
                });

                request.always(function() {
                    //al finalizar
                });
            });


    //boton de ver los datos
    $(".js-view").on("click",function(evt) {
                evt.preventDefault();
               //codigo del registro a modificar
               
                var valor = $(this).attr('data-key');
                $('#myModal-label').html('Mostrar Estudiante');

                var url = urls.controller + '/' + urls.actions.view;
                var request = $.get(url, { id: valor }, "html");

                request.done(function(data) {
                    $('#modalBody').html(data);
                    $('#myModal').modal('show');
                });

                request.fail(function(jqXHR, textStatus) {
                    $('#modalBody').html(jqXHR.responseText);
                    $('#myModal').modal('show');
                });

                request.always(function() {
                    //al finalizar
                });


            });


    //boton para crear un nuevo registro
    $('.js-new').on('click',function(evt) {
                evt.preventDefault();
                evt.stopPropagation();
                var valor = 0;
                $('#myModal-label').html('Nuevo Estudiante');

                var url = urls.controller + '/' + urls.actions.create;
                var request = $.get(url, { id: valor }, "html");

                request.done(function(data) {
                    $('#modalBody').html(data);
                    $('#myModal').modal('show');
                });

                request.fail(function(jqXHR, textStatus) {
                    $('#modalBody').html(jqXHR.responseText);
                    $('#myModal').modal('show');
                });

                request.always(function() {
                    //al finalizar
                });

            });

    //seleccionar un registro de la grilla
    var currentSelect = "";
    $("tbody tr").on('click',function(evt) {
                if (currentSelect != "") {
                    $(currentSelect).removeClass('success');
                }
                currentSelect = "#" + $(this).attr("id");
                $(this).addClass("success");
                $("#actionmenurow").css("display", "");
                $("#panel02").removeClass("hidden");  
                debugger;
                var nombre = $(this).find("td:nth-child(2)").html();
                $("#prueba01").html("Cursos de " + nombre.trim());
    });

    //limpiar los datos contenidos al cerrar la ventana modal
    $("#myModal").on("hidden.bs.modal",function() {
            $("#modalBody").html("");
        });

    function ToJavaScriptDate(value) {
        var pattern = /Date\(([^)]+)\)/;
        var results = pattern.exec(value);
        var dt = new Date(parseFloat(results[1]));
        return (dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear();
    }

}); //fin de la funcion de jquery

addEventsGrid(jQuery);

