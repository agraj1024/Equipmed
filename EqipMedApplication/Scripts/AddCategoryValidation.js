$(document).ready(function () {
    $("#form1").validate(    {
        focusInvalid: false,        focusCleanup: false,        debug: false,        onkeyup: false,        onclick: false,        onsubmit: true,        onkeyup: false,        rules:        {
            txtCategoryName: { required: true },            txtCategoryDescription: { required: true },                   },        messages:        {
            txtCategoryName: { required: "Please Enter Category Name" },            txtCategoryDescription: { required: "Please Detailed Category Description" },

        },
        submitHandler: function (form) {
            form.submit();
        }
    });
});