"use strict";

// CLIENT-SIDE JSON MODEL-MAPPING :
$('#json_data_table').DataTable({
    "aaData": getJsonData()
});

function getJsonData() {
    var arrayReturn = [];
    $.ajax({
        url: "/Home/JsonModel/",
        async: false,
        dataType: 'json',
        success: function (data) {
            for (var i = 0, len = data.length; i < len; i++) {
                arrayReturn.push([
                    data[i].Id,
                    data[i].IsActive,
                    data[i].Name,
                    data[i].Number,
                    window.moment(data[i].Created).format("DD/MM/YYYY")
                ]);
            }
        }
    });
    return arrayReturn;
}

// SERVER-SIDE PROCCESSING :
$(() => {
    if ($('#my-data-table').length !== 0) {

        $('#my-data-table thead tr:last th').each(function () {
            var label = $('#my-data-table thead tr:first th:eq(' + $(this).index() + ')').html();
            $(this)
                .addClass('p-0')
                .html('<span class="sr-only">' + label + '</span><input type="search" class="form-control form-control-sm" aria-label="' + label + '" />');
        });

        var table = $('#my-data-table').DataTable({
            language: {
                processing: "Loading Data...",
                zeroRecords: "No matching records found"
            },
            processing: true,
            serverSide: true,
            orderCellsTop: true,
            autoWidth: true,
            deferRender: true,
            dom: '<tr>',
            ajax: {
                type: "POST",
                url: '/Home/ServerSideModel/',
                contentType: "application/json; charset=utf-8",
                async: true,
                headers: {
                    "XSRF-TOKEN": document.querySelector('[name="__RequestVerificationToken"]').value
                },
                data: function (data) {
                    let additionalValues = [];
                    additionalValues[0] = "Additional Parameters 1";
                    additionalValues[1] = "Additional Parameters 2";
                    data.AdditionalValues = additionalValues;
                    return JSON.stringify(data);
                }
            },
            columns: [
                {
                    title: "Id",
                    data: "Id",
                    name: "eq"
                },
                {
                    title: "Name",
                    data: "Name",
                    name: "eq"
                },
                {
                    title: "Is Active",
                    data: "IsActive",
                    name: "co"
                },
                {
                    title: "Created at",
                    data: "Created",
                    render: function (data, type, row) {
                        return window.moment(row.Created).format("DD/MM/YYYY");
                    },
                    name: "gt"
                },
                {
                    title: "Number",
                    data: "Number",
                    name: "lte"
                }
            ]
        });

        table.columns().every(function (index) {
            $('#my-data-table thead tr:last th:eq(' + index + ') input')
                .on('keyup',
                    function (e) {
                        if (e.keyCode === 13) {
                            table.column($(this).parent().index() + ':visible').search(this.value).draw();
                        }
                    });
        });
    }
});