
Handlebars.registerHelper("formatName", function (prop1, prop2) {
    return "Hello  " + prop1 + " Age: " + prop2;
});

Handlebars.registerHelper("formatAnotherName", function (prop1, prop2) {
    return new Handlebars.SafeString(
        "Dear  <strong>" + prop1 + "</strong> Age: " + prop2
    );
});

Handlebars.registerHelper("formatNumber", function (prop1) {
    if (prop1) {
        var phone = prop1.toString();
        return "(" + phone.substr(0, 3) + ") " + phone.substr(3, 3) + " - " + phone.substr(6, phone.length);
    }

});

Handlebars.registerHelper("makeBold", function (options) {
    return new Handlebars.SafeString(
        "<i>" + options.fn(this) + "</i>"
    );
});

Handlebars.registerHelper("toLower", function (options) {
    return options.fn(this).toLowerCase();
});

Handlebars.registerHelper("toUpper", function (options) {
    return options.fn(this).toUpperCase();
});




let model = {
    names: [
        { name: "Adam", age: 22, num: 1234567890 },
        { name: "Sam", age: 22, num: 65745674567 },
        { name: "Quentin", age: 22, num: 543477347 },
        { name: "Sally", age: 22 },
        { name: "Croft", age: 22, num: 465456568 }
    ]
}

var mod = {
    names: []

}


var template = Handlebars.compile($("#template").html());

$(document).ready(() => {


    AddToDom();


});

function AddToDom() {

    mod.names = model.names.splice(0, 2);

    if (mod.names.length == 0) {
        location.reload();
    }

    $(".container").html(template(mod));

    setTimeout(AddToDom, 5000);
}