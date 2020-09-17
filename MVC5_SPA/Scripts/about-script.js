$(function () {
    console.warn("About2 Javascript called");
    var datepicker = $("#datepicker").data("kendoDatePicker");
    datepicker.value(new Date(2022, 02, 02));
});

function textboxOnChange () {
    console.warn("textboxOnChange Javascript called");
    var textbox = $("#textbox").data("kendoTextBox");
    textbox.value("test");
};