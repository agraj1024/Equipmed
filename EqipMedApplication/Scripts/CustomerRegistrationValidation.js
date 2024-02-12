$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtCustomerName: { required: true },            txtCustomerEmail: { required: true, email: true },            txtCustomerPhone: { required: true, digits: true, minlength: 10, maxlength: 10 },            txtCustomerAddress: { required: true },            txtCustomerPassword: { required: true, minlength: 4, rangelength: [4, 20] },            txtDOB: { required: true },            txtReEnterPassword: { required: true, minlength: 4, rangelength: [4, 20],equalTo:txtCustomerPassword },        },            messages:            {
                txtCustomerName: { required: "Please enter full name" },                txtCustomerEmail: { required: "Please enter Email ID", email: "Please enter email in proper format" },                txtCustomerPhone: { required: "Please enter Contact Number", digits: "Only digits accepted", minlength: "A minimum of {0} digits are required.", maxlength: "A maximum of {0} digits are required." },                txtCustomerAddress: { required: "Please enter Address" },                txtDOB: { required: "Please enter DOB" },                txtCustomerPassword: { required: "Please enter Password", minlength: "A minimum of {0} digits are required.", rangelength: "Password should be between {0} and {1} characters long" },                txtReEnterPassword: { required: "Please Re enter Password", minlength: "A minimum of {0} digits are required.", rangelength: "Password should be between {0} and {1} characters long",equalTo:"Entered Passwords Do Not Match"}
            },
                submitHandler: function (form) {
            form.submit();
        }
    });
});

