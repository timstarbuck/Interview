var arr = new Array(99);
for(var i = 0;i< arr.length;i++){
    if (i <= 1) {
        arr[i] = i
    } else {
        arr[i] = arr[i-1] + arr[i-2];
    }
    console.log(arr[i]);
}