for (var index = 1; index <= 100; index++) {
    var isThree = (index % 3 ) === 0;
    var isFive = (index % 5) === 0;
    if ((isThree) && (isFive)) {
        console.log("FizzBuzz");
    } else if(isThree) {
        console.log("Fizz");
    } else if (isFive) {
        console.log("Buzz");
    } else {
        console.log(index);
    }
}
 