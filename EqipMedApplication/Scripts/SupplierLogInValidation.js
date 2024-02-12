$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtSupplierEmail: { required: true, email: true },            txtSupplierPassword: { required: true },
        },        messages:        {
            txtSupplierEmail: { required: "Please Enter a Registered Email ", email: " Please use the correct email format" },            txtSupplierPassword: { required: "Please Enter a Password" },

        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});