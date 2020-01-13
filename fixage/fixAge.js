
function fixage(array) {
    var result = array.filter(element => element >= 18 && element <= 60);
    if (result.length > 0) {
        return result.join()
    }
    return "NA"
}