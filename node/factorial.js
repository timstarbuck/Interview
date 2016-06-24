
console.log("4! = " + computeFactorial(4));
console.log("4! = " + computeFactorialLoop(4) + " loop");
console.log("100! = " + computeFactorial(100));
console.log("100! = " + computeFactorialLoop(100) + " loop");


function computeFactorial (n) {
    if (n == 1) {
        return 1;
    } else {
        return n * computeFactorial(n - 1);
    }    
}

function computeFactorialLoop (n) {
    var answer =1;
    for (var index = 2; index <= n; index++) {
        answer *= index;
    }
    return answer;
}