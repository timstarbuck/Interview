var aString = ["a", "b", "c", "d", "e"];

console.log(aString);

for (var index = 0; index < aString.length / 2; index++) {
    var element = aString[index];
    aString[index] = aString[aString.length - index - 1]
    aString[aString.length - index - 1] = element;
}
console.log(aString);

