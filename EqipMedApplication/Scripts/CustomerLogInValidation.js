﻿$(document).ready(function () {
    $("#form1").validate(
        focusInvalid: false,
            txtCustomerEmail: { required: true, email:true },

            txtCustomerEmail: { required: "Please Enter a Registered Email ", email:" Please use the correct email format" },

        },

            form.submit();
        }
    });
});