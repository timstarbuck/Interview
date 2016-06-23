var arr = [1, 4, 6, 7, 9, 12, 16, 42, 256, 500];

console.log(arr);

console.log("Index of 9 is "+ binarySearch(arr, 0, arr.length, 9));
console.log("Index of 12 is "+ binarySearch(arr, 0, arr.length, 12));
console.log("Index of 7 is "+ binarySearch(arr, 0, arr.length, 7));
console.log("Index of 16 is "+ binarySearch(arr, 0, arr.length, 16));
console.log("Index of 9 is "+ binarySearchLoop(arr, 9) + " (loop)");
console.log("Index of 12 is "+ binarySearchLoop(arr, 12) + " (loop)");
console.log("Index of 7 is "+ binarySearchLoop(arr, 7) + " (loop)");
console.log("Index of 16 is "+ binarySearchLoop(arr, 16) + " (loop)");

function binarySearch(arr, left, right, key) {
    if (left > right) {
        return -1;
    }

    var mid = Math.floor((left + right) / 2);

    if (arr[mid] === key) {
        return mid;
    }
    if (arr[mid] > key){
        return binarySearch(arr, left, mid -1, key);
    }

    return binarySearch(arr, mid+1, right, key);
}

function binarySearchLoop(arr, key) {
    var low = 0, mid = 0, high = arr.length -1;
    while (low <= high) {
        mid = low + Math.floor((high - low) / 2);
        if (key < arr[mid]){
            high = mid - 1;
        } else if (key > arr[mid]) {
            low = mid + 1;
        } else {
            return mid;
        }
    }
    return -1;
}
