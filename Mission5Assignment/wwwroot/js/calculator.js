function calculateCost() {
    let hours = document.getElementById("hours").value;
    if (hours <= 0 || isNaN(hours)) {
        alert("Please enter a valid positive number.");
        return;
    }
    let rate = 30;
    let total = hours * rate;
    document.getElementById("total").innerText = "$" + total;
}