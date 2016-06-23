
console.log("Prime numbers up to 1000");

for (var i = 1; i < 1000; i++) {
    if (isPrime(i)) {
        console.log(i);
    }
}
    

function isPrime(number) {
    var boundary =  Math.floor(Math.sqrt(number));

    if (number == 1) return false;
    if (number == 2) return true;

    for (var i = 2; i <= boundary; ++i)
    {
        if (number % i == 0) return false;
    }

    return true;    
}