var arr = [99, 187, 5, 3, 4, 12., 91, 66, 3, 1, 77, 55];
var didSwap = true;
var loopCount = 0;
do {
    loopCount++;
    didSwap = false;
    for(var i = 0;i<arr.length;i++){
        if (i > 0){
            if (arr[i] < arr[i-1]){
                var temp = arr[i-1];
                arr[i -1] = arr[i];
                arr[i] = temp;
                didSwap = true; 
            }
        }
    }
} while(didSwap === true)
console.log(arr);
console.log("Took " + loopCount + " loops." );