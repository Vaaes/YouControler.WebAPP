function HasPermission(menu) {
    $.ajax({
        type: 'GET',
        url: "/Home/HasPermissionAllowed",
        data: { IdMenu: menu },
        success: function (result) {
            $.each(result, function (i, item) {
                if (item.ler == 1) { $("#btn-filtra").show(); }
                if (item.criar == 1) { $("#btn-insert").show(); }
                if (item.alterar == 1) { $(".btn-edit").show(); }
                if (item.deletar == 1) { $(".btn-excluir").show(); }
            })
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function configureSweetSuccess(title, url) {
    Swal.fire({
        title: title,
        showDenyButton: false,
        showCancelButton: false,
        confirmButtonText: 'Ok',
        icon: 'success'
    }).then((result) => {
        if (result.isConfirmed) {
            location.href = url;
        }
    })
}

function configureSweetError(title) {
    Swal.fire(
        'Erro!',
        title,
        'error'
    )
}

function AjaxHelper(type, url, data, callback) {
    $.ajax({
        type: type,
        url: url,
        data: data,
        success: function (result) {
            callback(result);
        },
        error: function (error) {
            alert(error)
        }
    });
}
