function GetSomeJson() {
    $.getJSON("http://localhost:51616/contact.aspx")
        .done(function (data) {
            $("#myTableBody").children().remove();
            console.log(data);
        var newTbody = "";
        var newTbodyAdress = "";

        
        for (var i = 0; i < data.length; i++) {
            newTbody += "<tr><td>" + data[i].FirstName + "</td>";
            newTbody += "<td>" + data[i].LastName + "</td>";
            newTbody += "<td>" + data[1].ID + "</td></tr>";
        }
        $("#myTableBody").append(newTbody);
        newTbodyAdress += "<tr><td>" + data[0].myAdress[0].Street + "</td></tr>";
        $("#myTableBodyAdress").append(newTbodyAdress);


    });     
}
