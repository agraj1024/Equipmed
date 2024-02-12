$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtCustomerEmail: { required: true, email:true },            txtCustomerPassword: { required: true },
        },        messages:        {
            txtCustomerEmail: { required: "Please Enter a Registered Email ", email:" Please use the correct email format" },            txtCustomerPassword: { required: "Please Enter a Password" },

        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});