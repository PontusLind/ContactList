function GetContacts() {
    $.getJSON("http://localhost:56993/contact.aspx")
        .done(function (data) {
            $("#myTableBody").children().remove();

            var newTbody = "";

            for (var i = 0; i < data.length; i++) {
                newTbody += "<tr><td><button onclick='UpdateContact(" + data[i].ID + ")' type='button'>" + data[i].FirstName + "</button></td>";
                newTbody += "<td>" + data[i].LastName + "</td>";
                newTbody += "<td>" + data[i].ID + "</td>";
                newTbody += "<td>" + "</td></tr>";
            }
            $("#myTableBody").append(newTbody);
        });
}
function UpdateContact(ID) {
    $.getJSON("http://localhost:56993/contact.aspx?ID=" + ID)
        .done(function (data) {
            $("#myTableBody").children().remove();

            var newTbody = "";

            for (var i = 0; i < data.length; i++) {
                newTbody += "<tr><td>" + data[i].FirstName + "</td>";
                newTbody += "<td>" + data[i].LastName + "</td>";
                newTbody += "<td>" + data[i].ID + "</td><td>";
               

                //for (var j = 0; j < data[i].Adresses.length; j++) {
                //    myTR += data[i].Adresses[j].Type + ": " + data[i].Adresses[j].Street + "<br\>";
                //}
                newTbody += "</td></tr>";
                $("#myTableBody").append(newTbody);
            }
        });
}
