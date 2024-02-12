$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtSupplierName: { required: true },            txtSupplierEmail: { required: true, email: true },            txtSupplierPhone: { required: true, digits: true, minlength: 10, maxlength: 10 },            txtSupplierAddress: { required: true },            txtSupplierPassword: { required: true, minlength: 4, rangelength: [4, 20] },            txtReEnterPassword: { required: true, minlength: 4, rangelength: [4, 20], equalTo:txtSupplierPassword },
        },        messages:        {
            txtSupplierName: { required: "Please enter full name" },            txtSupplierEmail: { required: "Please enter Email ID", email: "Please enter email in proper format" },            txtSupplierPhone: { required: "Please enter Contact Number", digits: "Only digits accepted", minlength: "A minimum of {0} digits are required.", maxlength: "A maximum of {0} digits are required." },            txtSupplierAddress: { required: "Please enter Address" },            txtSupplierPassword: { required: "Please enter Password", minlength: "A minimum of {0} digits are required.", rangelength: "Password should be between {0} and {1} characters long" },            txtReEnterPassword: { required: "Please Re enter Password", minlength: "A minimum of {0} digits are required.", rangelength: "Password should be between {0} and {1} characters long", equalTo:"The entered passwords do not match" },
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});