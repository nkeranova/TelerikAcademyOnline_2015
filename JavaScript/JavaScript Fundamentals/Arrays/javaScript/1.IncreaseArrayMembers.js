/**
 Problem 1. Increase array members
 Write a script that allocates array of 20 integers and initializes
 each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

var arr = [],
    i;
arr.length = 20;

for (i = 0; i < arr.length - 1; i += 1){
    arr [i] = i * 5;
}
console.log(arr);