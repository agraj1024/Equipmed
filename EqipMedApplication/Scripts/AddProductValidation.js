$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtProductName: { required: true },            txtProductDescription: { required: true },            txtProductPrice: { required: true, digits: true, minlength: 1, maxlength: 20 },            fluProductImage: { required: true },            txtProductStock: { required: true, digits:true, minlength: 1, maxlength:20},            txtCategoryID: { required: true},
        },        messages:        {
            txtProductName: { required: "Please Enter Product Name" },            txtProductDescription: { required: "Please Detailed Product Description" },            txtProductPrice: { required: "Please Enter Price", digits: "Only digits accepted", minlength: "A minimum of {0} digits are required.", maxlength: "A maximum of {0} digits are required." },            fluProductImage: { required: "Please Enter Image Path", digits: "Only digits accepted" },            txtProductStock: { required: "Please Enter Stock"},            txtCategoryID: { required: "Please Enter Category ID"},
        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});