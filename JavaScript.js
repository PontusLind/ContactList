function GetSomeJson() {
    $.getJSON("http://localhost:51616/contact.aspx")
        .done(function (data) {
        $("#myTableBody").children().remove();

        var newTbody = "";

        for (var i = 0; i < data.length; i++) {
            newTbody += "<tr><td>" + data[i].FirstName + "</td>";
            newTbody += "<td>" + data[i].LastName + "</td>";
            newTbody += "<td>" + data[i].ID + "</td></tr>";
        }
        $("#myTableBody").append(newTbody);
    });     
}
