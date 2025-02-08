$(document).ready(function () {
    $('#calculate').click(function () {
        var hours = $('#hours').val();  // Get the value from the input box
        if (hours > 0) {  // Check if the entered hours is a positive number
            var total = hours * 30; // $30 per hour for hockey training
            $('#total').val('$' + total);  // Output the calculated total in the 'total' box
        } else {
            alert('Please enter a positive number of hours.');
        }
    });
});

}