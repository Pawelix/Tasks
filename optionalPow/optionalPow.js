var result
function optionalPow(a, b) {
    if (confirm('')) {
        result = Math.pow(a, b)
        return alert(result);
    } else {
        result = Math.pow(b, a)
        return alert(result);
    }
}