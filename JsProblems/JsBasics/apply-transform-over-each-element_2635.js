/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
    let updatedArr = new Array(arr.length);

    for (let i = 0; i < arr.length; i++) {
        updatedArr[i] = fn(arr[i], i);        
    }

    return updatedArr;
};


let sourceArr = [1, 3, 5, 6];
let sumFunc = function(a, b) {
    return a + b;
};

let returnedArray = map(sourceArr, sumFunc);

console.log(returnedArray);

