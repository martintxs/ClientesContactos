let Cliente = {
    Variables: {
        dtClientes: null,
        dtContactos: null,
        idCliente: 0,
        idContacto: 0,
    },
    Constantes: {
        urlLeerClientes: $("#urlLeerClientes").val(),
        urlLeerCliente: $("#urlLeerCliente").val(),
        urlSaveCliente: $("#urlSaveCliente").val(),
        urlDeleteCliente: $("#urlDeleteCliente").val(),

        urlLeerContactos: $("#urlLeerContactos").val(),
        urlLeerContacto: $("#urlLeerContacto").val(),
        urlSaveContacto: $("#urlSaveContacto").val(),
        urlDeleteContacto: $("#urlDeleteContacto").val(),
        colClientes:
            [
                {
                    "data": "RazonSocial",
                    "class": "text-center"
                },
                {
                    "data": "NombreComercial",
                    "class": "text-center"
                },
                {
                    "data": "RFC",
                    "class": "text-center"
                },
                {
                    "data": "CURP",
                    "class": "text-center"
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnVerContactos'><i class='fas fa-trash-alt'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEditarCliente'><i class='fas fa-edith'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEliminarCliente'><i class='fas fa-trash-alt'></i></a>"; }
                }
            ],
        colContactos:
            [
                {
                    "data": "Nombre",
                    "class": "text-center"
                },
                {
                    "data": "ApellidoPaterno",
                    "class": "text-center"
                },
                {
                    "data": "ApellidoMaterno",
                    "class": "text-center"
                },
                {
                    "data": "Telefono",
                    "class": "text-center"
                },
                {
                    "data": "Direccion",
                    "class": "text-center"
                },
                {
                    "data": "Puesto",
                    "class": "text-center"
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEditarContacto'><i class='fas fa-edith'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEliminarContacto'><i class='fas fa-trash-alt'></i></a>"; }
                }
            ]
    },
    Controles: {
        dtClientes: $("dtClientes"),
        btnModalNuevoCliente: $('#btnNuevoCliente'),
        btnVerContactos: $(document),
        btnEditarCliente: $(document),
        btnEliminarCliente: $(document),
        btnEditarContacto: $(document),
        btnEliminarContacto: $(document),
        modalContacto: $("#modalContacto"),
        txtNombre: $("#txtNombre"),
        txtApellidoPaterno: $("#txtApellidoPaterno"),
        txtApellidoMaterno: $("#txtApellidoMaterno"),
        txtTelefono: $("#txtTelefono"),
        txtDireccionContacto: $("#txtDireccionContacto"),
        txtPuesto: $("#txtPuesto"),
        btnGuardarContactoDetalle: $("#btnGuardarContactoDetalle"),

        modalCliente: $("#modalCliente"),
        txtRazonSocial: $("#txtRazonSocial"),
        txtNombreComercial: $("#txtNombreComercial"),
        txtRFC: $("#txtRFC"),
        txtCURP: $("#txtCURP"),
        txtDireccion: $("#txtDireccion"),
        btnGuardarCliente: $("#btnGuardarCliente"),

        modalContactos: $("#modalContactos"),
        dtContactos: $("dtContactos"),
        btnModalNuevoContacto: $("btnModalNuevoContacto"),
    },
    Eventos: {
        InicializaEventos: function () {
            Cliente.Controles.btnModalNuevoCliente.on("click", Cliente.Funciones.ClickBtnModalNuevoCliente);
            Cliente.Controles.btnModalNuevoContacto.on("click", Cliente.Funciones.ClickBtnModalNuevoContacto);
            Cliente.Controles.btnVerContactos.on("click", ".btnVerContactos", Cliente.Funciones.ClickBtnVerContactos);
            Cliente.Controles.btnEditarCliente.on("click", ".btnEditarCliente", Cliente.Funciones.ClickBtnEditarCliente);
            Cliente.Controles.btnEliminarCliente.on("click", ".btnEliminarCliente", Cliente.Funciones.ClickBtnEliminarCliente);
            Cliente.Controles.btnEditarContacto.on("click", ".btnEditarContacto", Cliente.Funciones.ClickBtnEditarContacto);
            Cliente.Controles.btnEliminarContacto.on("click", ".btnEliminarContacto", Cliente.Funciones.ClickBtnEliminarContacto);
            Cliente.Controles.btnGuardarCliente.on("click", Cliente.Funciones.ClickBtnGuardarCliente);
            Cliente.Controles.btnGuardarContactoDetalle.on("click", Cliente.Funciones.ClickBtnGuardarContactoDetalle);
        }
    },
    Funciones: {
        ClickBtnModalNuevoCliente: function () {
            Cliente.Funciones.LimpiarModalCliente();
            Cliente.Controles.modalCliente.modal("show");
        },
        ClickBtnGuardarCliente: function () {
            let VoCliente = {
                IdCliente: Cliente.Variables.idCliente,
                RazonSocial: Cliente.Controles.txtRazonSocial.val(),
                NombreComercial: Cliente.Controles.txtNombreComercial.val(),
                RFC: Cliente.Controles.txtRFC.val(),
                CURP: Cliente.Controles.txtCURP.val(),
                Direccion: Cliente.Controles.txtDireccion.val()
            };

            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlSaveCliente, { VoCliente: VoCliente }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Controles.modalCliente.modal("hide");
                    MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnModalNuevoContacto: function () {
            Cliente.Funciones.LimpiarModalContacto();
            Cliente.Controles.modalContacto.modal("show");
        },
        ClickBtnGuardarContactoDetalle: function () {
            let VoContacto = {
                IdContacto: Cliente.Variables.idContacto,
                IdCliente: Cliente.Variables.idCliente,
                Nombre: Cliente.Controles.txtNombre.val(),
                ApellidoPaterno: Cliente.Controles.txtApellidoPaterno.val(),
                ApellidoMaterno: Cliente.Controles.txtApellidoMaterno.val(),
                Telefono: Cliente.Controles.txtTelefono.val(),
                Direccion: Cliente.Controles.txtDireccionContacto.val(),
                Puesto: Cliente.Controles.txtPuesto.val(),
            };

            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlSaveContacto, { VoContacto: VoContacto }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Controles.modalContacto.modal("hide");
                    MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnVerContactos: function () {
            Cliente.Variables.idCliente = Analisis.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerContactos, { Id: Cliente.Variables.idCliente }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Variables.dtContactos = FuncionesGenerales.InicializaDataTable(Cliente.Controles.dtContactos, data.Clientes, Cliente.Constantes.colClientes);
                    Cliente.Controles.modalContactos.modal("show");

                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnEditarCliente: function () {

        },
        ClickBtnEliminarCliente: function () {
            let IdCliente = Analisis.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            MensajesGenerales.ConfirmarMensajeAdvertencia(`Se eliminara el cliente. ¿Desea continuar?`, function () {
                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlDeleteCliente, { IdCliente: IdCliente }, data => {
                    if (data.Respuesta.Estatus) {
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }, function () { });
        },
        ClickBtnEditarContacto: function () {

        },
        ClickBtnEliminarContacto: function () {
            let IdContacto = Analisis.Variables.dtContactos.row($(this).closest('tr')).data().IdContacto;
            MensajesGenerales.ConfirmarMensajeAdvertencia(`Se eliminara el contacto. ¿Desea continuar?`, function () {
                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlDeleteContacto, { IdContacto: IdContacto }, data => {
                    if (data.Respuesta.Estatus) {
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }, function () { });
        },
        Leer: function () {
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerClientes, {}, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Variables.dtClientes = FuncionesGenerales.InicializaDataTable(Cliente.Controles.dtClientes, data.Clientes, Cliente.Constantes.colClientes);
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        LimpiarModalCliente: function () {
            Cliente.Variables.idCliente = 0;
            Cliente.Controles.txtRazonSocial.val("");
            Cliente.Controles.txtNombreComercial.val("");
            Cliente.Controles.txtRFC.val("");
            Cliente.Controles.txtCURP.val("");
            Cliente.Controles.txtDireccion.val("");
        },
        LimpiarModalContacto: function () {
            Cliente.Variables.idContacto = 0;
            Cliente.Controles.txtNombre.val("");
            Cliente.Controles.txtApellidoPaterno.val("");
            Cliente.Controles.txtApellidoMaterno.val("");
            Cliente.Controles.txtTelefono.val("");
            Cliente.Controles.txtDireccionContacto.val("");
            Cliente.Controles.txtPuesto.val("");
        },
        Init: function () {
            Cliente.Eventos.InicializaEventos();
            Cliente.Funciones.Leer();
        }
    }
};

Cliente.Funciones.Init();