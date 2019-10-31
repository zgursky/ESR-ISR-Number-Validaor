function isrReferenceNumberValivation(number) {        
    const table = [0, 9, 4, 6, 8, 2, 7, 1, 3, 5];
    let carry = 0;
    var controlDigit = number.substr(number.length - 1);
    number = number.substring(0, number.length - 1);
    for (let i = 0; i < number.length; i += 1) {
        const c = parseInt(number.charAt(i), 10);
        const index = (carry + c) % 10;
        if (!isNaN(index)) {
            carry = table[index];
        }          
    }
    var calculatedContolDigit = (10 - carry) % 10;
    var isSuccess = calculatedContolDigit == controlDigit;        
    return isSuccess;
}
