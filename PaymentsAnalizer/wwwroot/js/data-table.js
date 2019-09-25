$(document).ready(function () {
	$('#my_datatable_basic').DataTable({
		// processing: true,
		info: true,
		paging: true,
		serverSide: true, // SERVER-SIDE !!!
		ajax: {
			url: "/Payments/IndexJson",
			type: "POST",
			//contentType: "application/json; charset=utf-8",
			//dataType: "json",
			"dataSrc": function (json) {

				var jsonParsed = JSON.parse(json)["data"];

				for (var i = 0, ien = jsonParsed.length; i < ien; i++) {
					jsonParsed[i][3] = '<b>' + jsonParsed[i][3] + '</b>';
				}

				return jsonParsed;
			},

			//success: function (data) {
			//	var jsonParsed = JSON.parse(data)["data"];
			//	console.log(jsonParsed[0]); //["payDate"]);
			//	for (var i = 0; i < jsonParsed.length; i++) {
			//		console.log(i + " - " + jsonParsed[i]["category"]["name"]);
			//	}
			//},
			//error: function () { alert(this.error.name); },
		}
	});
});