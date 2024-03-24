var js = jQuery.noConflict(true);
var dataTable;
js(document).ready(function () {
    loadDataTable();
});

function formatNumberToTwoDecimals(data) {
    return parseFloat(data).toFixed(2);
}

function loadDataTable() {
    dataTable = js('#tblData').DataTable({
        "ajax": {
            type: 'Get',
            url: '/admin/product/getall'
        },
        "columns": [
            { data: 'title','width':'25%' },
            { data: 'author','width':'15%' },
            { data: 'isbn', 'width': '15%' },
            { data: 'price', render: formatNumberToTwoDecimals,'width': '10%' },
            { data: 'category.name', 'width': '15%' },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-80 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-success mx-2"><i class="bi bi-pencil-square"></i> Edit</a>
                        <a onClick=Delete("/admin/product/delete?id=${data}") class="btn btn-danger mx-2"><i class="bi bi-trash-fill"></i> Delete</a>
                        
                    </div>`
                },
                'width': '20%'
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            js.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}