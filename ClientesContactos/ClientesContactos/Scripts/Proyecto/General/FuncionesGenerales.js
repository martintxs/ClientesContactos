var FuncionesGenerales = {
    InicializaDataTable: function (_tabla, _data, _columnas, _orderBy = 0, _orden = 'asc', _paginada = true, _fixedHeader = true, _busqueda = true, _info = true, _ordering = true) {
        let table = _tabla.DataTable({
            language: this.Constantes.lenguajeDataTable,
            responsive: true,
            fixedHeader: _fixedHeader,
            searching: _busqueda,
            "bSort": false,
            search: {
                smart: false
            },
            "bAutoWidth": false,
            "bLengthChange": true,
            "bPaginate": _paginada,
            destroy: true,
            data: _data,
            columns: _columnas,
            ordering: _ordering,
            info: _info,
            "order": [_orderBy, _orden]
        });

        return table;
    },
    LlamadaAjax: function (url, parametros, funcionSuccess) {
        return $.ajax({
            url: url,
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(parametros),
            success: funcionSuccess,
            error: function (xmlHttpRequest, errorThrown) {
                if (xmlHttpRequest.status === 511) {
                    MensajesGenerales.MensajeAdvertencia('La sesión ha expirado.<br>Por favor inicie sesión nuevamente.');
                } else {
                    MensajesGenerales.MensajeError(errorThrown + '<br>' + xmlHttpRequest.responseText);
                }
            }
        });
    },
    ValidaCamposRequeridos: function (Group) {
        var Campos = "";
        var Mensaje = "";

        $('input' + Group).each(function () {
            if ($(this).val().trim() === "") {
                Campos += "- " + $(this).attr('item') + "  <br>";
            }
        });
        $('select' + Group).each(function (idx, obj) {
            if ($(obj).val() === "" || $(obj).val() === -1 || $(obj).val() === '-1') {
                Campos += "- " + $(this).attr('item') + "  <br>";
            }
        });
        $('select.multiple' + Group).each(function (idx, obj) {
            if ($(obj).val === []) {
                Campos += "- " + $(this).attr('item') + "  <br>";
            }
        });
        $('textarea' + Group).each(function () {
            if ($(this).val() === "") {
                Campos += "- " + $(this).attr('item') + "  <br>";
            }
        });
        $('input[type=radio]' + Group).each(function () {
            let name = $(this).attr('name');
            let val = $('input[name=' + name + ']:checked').val()
            if (val == null) {
                Campos += "- " + $(this).attr('item') + "  <br>";
            }
        });

        if (Campos.length > 0) {
            Mensaje = "Los siguientes campos son requeridos: <br> " + "<div class='text-left'>" + Campos + "</div>";
        }

        return Mensaje;
    },
    Controles: {
        documento: $(document)
    },
    Constantes: {
        lenguajeDataTable: {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No hay registros.",
            "sEmptyTable": "No hay registros.",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    }
};