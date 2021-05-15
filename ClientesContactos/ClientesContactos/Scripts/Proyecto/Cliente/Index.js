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
        urlReporte: $("#urlReporte").val(),

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
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnVerContactos'><i class='fas fa-eye'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnGenerarReporte'><i class='fas fa-file-pdf'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEditarCliente'><i class='fas fa-user-edit'></i></a>"; }
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
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEditarContacto'><i class='fas fa-user-edit'></i></a>"; }
                },
                {
                    "class": "text-center",
                    "render": () => { return "<a class='btn btn-primary-light btn-sm btnEliminarContacto'><i class='fas fa-trash-alt'></i></a>"; }
                }
            ]
    },
    Controles: {
        dtClientes: $("#dtClientes"),
        btnModalNuevoCliente: $('#btnNuevoCliente'),
        btnVerContactos: $(document),
        btnGenerarReporte: $(document),
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
        dtContactos: $("#dtContactos"),
        btnModalNuevoContacto: $("#btnModalNuevoContacto"),
        btnFiltroContacto: $("#btnFiltroContacto"),
        modalContactoFiltro: {
            modalContactoFiltro: $("#modalContactoFiltro"),
            txtNombreFiltro: $("#txtNombreFiltro"),
            txtApellidoPaternoFiltro: $("#txtApellidoPaternoFiltro"),
            txtApellidoMaternoFiltro: $("#txtApellidoMaternoFiltro"),
            txtTelefonoFiltro: $("#txtTelefonoFiltro"),
            txtDireccionContactoFiltro: $("#txtDireccionContactoFiltro"),
            txtPuestoFiltro: $("#txtPuestoFiltro"),
            btnFiltrarContacto: $("#btnFiltrarContacto"),
        },
        btnFiltroCliente: $("#btnFiltroCliente"),
        modalClienteFiltro: {
            modalClienteFiltro: $("#modalClienteFiltro"),
            txtRazonSocialFiltro: $("#txtRazonSocialFiltro"),
            txtNombreComercialFiltro: $("#txtNombreComercialFiltro"),
            txtRFCFiltro: $("#txtRFCFiltro"),
            txtCURPFiltro: $("#txtCURPFiltro"),
            txtDireccionFiltro: $("#txtDireccionFiltro"),
            btnFiltrarCliente: $("#btnFiltrarCliente"),
        }
    },
    Eventos: {
        InicializaEventos: function () {
            Cliente.Controles.btnModalNuevoCliente.on("click", Cliente.Funciones.ClickBtnModalNuevoCliente);
            Cliente.Controles.btnModalNuevoContacto.on("click", Cliente.Funciones.ClickBtnModalNuevoContacto);
            Cliente.Controles.btnVerContactos.on("click", ".btnVerContactos", Cliente.Funciones.ClickBtnVerContactos);
            Cliente.Controles.btnGenerarReporte.on("click", ".btnGenerarReporte", Cliente.Funciones.ClickBtnGenerarReporte);
            Cliente.Controles.btnEditarCliente.on("click", ".btnEditarCliente", Cliente.Funciones.ClickBtnEditarCliente);
            Cliente.Controles.btnEliminarCliente.on("click", ".btnEliminarCliente", Cliente.Funciones.ClickBtnEliminarCliente);
            Cliente.Controles.btnEditarContacto.on("click", ".btnEditarContacto", Cliente.Funciones.ClickBtnEditarContacto);
            Cliente.Controles.btnEliminarContacto.on("click", ".btnEliminarContacto", Cliente.Funciones.ClickBtnEliminarContacto);
            Cliente.Controles.btnGuardarCliente.on("click", Cliente.Funciones.ClickBtnGuardarCliente);
            Cliente.Controles.btnGuardarContactoDetalle.on("click", Cliente.Funciones.ClickBtnGuardarContactoDetalle);
            Cliente.Controles.btnFiltroCliente.on("click", Cliente.Funciones.ClickBtnFiltroCliente);
            Cliente.Controles.modalClienteFiltro.btnFiltrarCliente.on("click", Cliente.Funciones.ClickBtnFiltrarCliente);
            Cliente.Controles.btnFiltroContacto.on("click", Cliente.Funciones.ClickBtnFiltroContacto);
            Cliente.Controles.modalContactoFiltro.btnFiltrarContacto.on("click", Cliente.Funciones.ClickBtnFiltrarContacto);
        }
    },
    Funciones: {
        ClickBtnFiltrarContacto: function () {
            Cliente.Funciones.LeerContactos();
            Cliente.Controles.modalContactoFiltro.modalContactoFiltro.modal("hide");
        },
        ClickBtnFiltrarCliente: function () {
            Cliente.Funciones.Leer();
            Cliente.Controles.modalClienteFiltro.modalClienteFiltro.modal("hide");
        },
        ClickBtnFiltroCliente: function () {
            Cliente.Funciones.LimpiarFiltroCliente();
            Cliente.Controles.modalClienteFiltro.modalClienteFiltro.modal("show");
        },
        ClickBtnFiltroContacto: function () {
            Cliente.Funciones.LimpiarFiltroContacto();
            Cliente.Controles.modalContactoFiltro.modalContactoFiltro.modal("show");
        },
        ClickBtnModalNuevoCliente: function () {
            Cliente.Funciones.LimpiarModalCliente();
            Cliente.Controles.modalCliente.modal("show");
        },
        ClickBtnGuardarCliente: function () {
            let Mensaje = FuncionesGenerales.ValidaCamposRequeridos(".reqGuardarCliente");
            if (Mensaje.length > 0) {
                MensajesGenerales.MensajeAdvertencia(Mensaje);
            } else {
                let VoCliente = {
                    IdCliente: Cliente.Variables.idCliente,
                    RazonSocial: Cliente.Controles.txtRazonSocial.val(),
                    NombreComercial: Cliente.Controles.txtNombreComercial.val(),
                    RFC: Cliente.Controles.txtRFC.val(),
                    CURP: Cliente.Controles.txtCURP.val(),
                    Direccion: Cliente.Controles.txtDireccion.val()
                };

                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlSaveCliente, { Cliente: VoCliente }, data => {
                    if (data.Respuesta.Estatus) {
                        Cliente.Controles.modalCliente.modal("hide");
                        Cliente.Funciones.Leer();
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }

        },
        ClickBtnModalNuevoContacto: function () {
            Cliente.Funciones.LimpiarModalContacto();
            Cliente.Controles.modalContacto.modal("show");
        },
        ClickBtnGuardarContactoDetalle: function () {
            let Mensaje = FuncionesGenerales.ValidaCamposRequeridos(".reqGuardarContacto");
            if (Mensaje.length > 0) {
                MensajesGenerales.MensajeAdvertencia(Mensaje);
            } else {
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

                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlSaveContacto, { Contacto: VoContacto }, data => {
                    if (data.Respuesta.Estatus) {
                        Cliente.Funciones.LeerContactos();
                        Cliente.Controles.modalContacto.modal("hide");
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }

        },
        ClickBtnVerContactos: function () {
            Cliente.Variables.idCliente = Cliente.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            let VoContacto = {
                IdCliente: Cliente.Variables.idCliente,
                Nombre: Cliente.Controles.modalContactoFiltro.txtNombreFiltro.val(),
                ApellidoPaterno: Cliente.Controles.modalContactoFiltro.txtApellidoPaternoFiltro.val(),
                ApellidoMaterno: Cliente.Controles.modalContactoFiltro.txtApellidoMaternoFiltro.val(),
                Telefono: Cliente.Controles.modalContactoFiltro.txtTelefonoFiltro.val(),
                Direccion: Cliente.Controles.modalContactoFiltro.txtDireccionContactoFiltro.val(),
                Puesto: Cliente.Controles.modalContactoFiltro.txtPuestoFiltro.val(),
            };
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerContactos, { Contacto: VoContacto }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Variables.dtContactos = FuncionesGenerales.InicializaDataTable(Cliente.Controles.dtContactos, data.Contactos, Cliente.Constantes.colContactos);
                    Cliente.Controles.modalContactos.modal("show");

                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnGenerarReporte: function () {
            let id = Cliente.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            var xhr = new XMLHttpRequest();
            var url = "../Cliente/Reporte/" + id ;
            xhr.open('GET', url);
            xhr.send();

            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    window.open(url,'_blank');
                }
            };

            xhr.onload = function (e) {
                if (xhr.status != 200) {
                    console.log(xhr.statusText);
                    MensajesGenerales.MensajeAdvertencia("Hubo un error al intentar descargar.");
                    xhr.abort();
                }
            };

            xhr.onerror = function (e) {
                MensajesGenerales.MensajeAdvertencia("Error fetching " + url);
            };
        },
        ClickBtnEditarCliente: function () {
            Cliente.Variables.idCliente = Cliente.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerCliente, { Id: Cliente.Variables.idCliente }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Controles.txtRazonSocial.val(data.Cliente.RazonSocial);
                    Cliente.Controles.txtNombreComercial.val(data.Cliente.NombreComercial);
                    Cliente.Controles.txtRFC.val(data.Cliente.RFC);
                    Cliente.Controles.txtCURP.val(data.Cliente.CURP);
                    Cliente.Controles.txtDireccion.val(data.Cliente.Direccion);
                    Cliente.Controles.modalCliente.modal("show");
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnEliminarCliente: function () {
            let IdCliente = Cliente.Variables.dtClientes.row($(this).closest('tr')).data().IdCliente;
            MensajesGenerales.MensajeConfirmacion(`Se eliminara el cliente. ¿Desea continuar?`, function () {
                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlDeleteCliente, { Id: IdCliente }, data => {
                    if (data.Respuesta.Estatus) {
                        Cliente.Funciones.Leer();
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }, function () { });
        },
        ClickBtnEditarContacto: function () {
            Cliente.Variables.idContacto = Cliente.Variables.dtContactos.row($(this).closest('tr')).data().IdContacto;
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerContacto, { Id: Cliente.Variables.idContacto }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Controles.txtNombre.val(data.Contacto.Nombre);
                    Cliente.Controles.txtApellidoPaterno.val(data.Contacto.ApellidoPaterno);
                    Cliente.Controles.txtApellidoMaterno.val(data.Contacto.ApellidoMaterno);
                    Cliente.Controles.txtTelefono.val(data.Contacto.Telefono);
                    Cliente.Controles.txtDireccionContacto.val(data.Contacto.Direccion);
                    Cliente.Controles.txtPuesto.val(data.Contacto.Puesto);
                    Cliente.Controles.modalContacto.modal("show");
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        ClickBtnEliminarContacto: function () {
            let IdContacto = Cliente.Variables.dtContactos.row($(this).closest('tr')).data().IdContacto;
            MensajesGenerales.MensajeConfirmacion(`Se eliminara el contacto. ¿Desea continuar?`, function () {
                FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlDeleteContacto, { Id: IdContacto }, data => {
                    if (data.Respuesta.Estatus) {
                        Cliente.Funciones.LeerContactos();
                        MensajesGenerales.MensajeExito(data.Respuesta.Mensaje);
                    } else {
                        MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                    }
                });
            }, function () { });
        },
        Leer: function () {
            let VoCliente = {
                RazonSocial: Cliente.Controles.modalClienteFiltro.txtRazonSocialFiltro.val(),
                NombreComercial: Cliente.Controles.modalClienteFiltro.txtNombreComercialFiltro.val(),
                RFC: Cliente.Controles.modalClienteFiltro.txtRFCFiltro.val(),
                CURP: Cliente.Controles.modalClienteFiltro.txtCURPFiltro.val(),
                Direccion: Cliente.Controles.modalClienteFiltro.txtDireccionFiltro.val()
            };
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerClientes, { Cliente: VoCliente }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Variables.dtClientes = FuncionesGenerales.InicializaDataTable(Cliente.Controles.dtClientes, data.Clientes, Cliente.Constantes.colClientes);
                } else {
                    MensajesGenerales.MensajeAdvertencia(data.Respuesta.Mensaje);
                }
            });
        },
        LeerContactos: function () {
            let VoContacto = {
                IdCliente: Cliente.Variables.idCliente,
                Nombre: Cliente.Controles.modalContactoFiltro.txtNombreFiltro.val(),
                ApellidoPaterno: Cliente.Controles.modalContactoFiltro.txtApellidoPaternoFiltro.val(),
                ApellidoMaterno: Cliente.Controles.modalContactoFiltro.txtApellidoMaternoFiltro.val(),
                Telefono: Cliente.Controles.modalContactoFiltro.txtTelefonoFiltro.val(),
                Direccion: Cliente.Controles.modalContactoFiltro.txtDireccionContactoFiltro.val(),
                Puesto: Cliente.Controles.modalContactoFiltro.txtPuestoFiltro.val(),
            };
            FuncionesGenerales.LlamadaAjax(Cliente.Constantes.urlLeerContactos, { Contacto: VoContacto }, data => {
                if (data.Respuesta.Estatus) {
                    Cliente.Variables.dtContactos = FuncionesGenerales.InicializaDataTable(Cliente.Controles.dtContactos, data.Contactos, Cliente.Constantes.colContactos);
                    Cliente.Controles.modalContactos.modal("show");

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
        LimpiarFiltroCliente: function () {
            Cliente.Controles.modalClienteFiltro.txtRazonSocialFiltro.val("");
            Cliente.Controles.modalClienteFiltro.txtNombreComercialFiltro.val("");
            Cliente.Controles.modalClienteFiltro.txtRFCFiltro.val("");
            Cliente.Controles.modalClienteFiltro.txtCURPFiltro.val("");
            Cliente.Controles.modalClienteFiltro.txtDireccionFiltro.val("");
        },
        LimpiarFiltroContacto: function () {
            Cliente.Controles.modalContactoFiltro.txtNombreFiltro.val("");
            Cliente.Controles.modalContactoFiltro.txtApellidoPaternoFiltro.val("");
            Cliente.Controles.modalContactoFiltro.txtApellidoMaternoFiltro.val("");
            Cliente.Controles.modalContactoFiltro.txtTelefonoFiltro.val("");
            Cliente.Controles.modalContactoFiltro.txtDireccionContactoFiltro.val("");
            Cliente.Controles.modalContactoFiltro.txtPuestoFiltro.val("");
        },
        Init: function () {
            Cliente.Eventos.InicializaEventos();
            Cliente.Funciones.Leer();
        }
    }
};

Cliente.Funciones.Init();