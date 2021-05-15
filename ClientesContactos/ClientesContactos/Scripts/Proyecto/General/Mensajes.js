var MensajesGenerales = {
    MensajeError: function (mensaje) {
        Swal.fire("Error", mensaje, 'error');
    },
    MensajeExito: function (mensaje) {
        Swal.fire({
            icon: 'success',
            title: "Éxito",
            text: mensaje,
            allowOutsideClick: true
        });
    },
    MensajeAdvertencia: function (mensaje) {
        Swal.fire("Advertencia", mensaje, 'warning');
    },
    MensajeConfirmacion: function (Mensaje, CallBackOk) {
        Swal.fire({
            title: 'Desea continuar?',
            text: Mensaje,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si, Continuar!'
        }).then((result) => {
            if (result.value) {
                CallBackOk();
            }
        });
    }
};