/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function(arr, fn) {
    let filteredArr = new Array();

    for (let i = 0; i < arr.length; i++) {
        if (fn(arr[i], i)){
            filteredArr.push(arr[i]);
        }   
    }

    return filteredArr;
};


let sourceArr = [1, 0, 5, 2, 3, 9, 1, 4, 7, 5, 11];
let validator = function(a, b) {
    if (a < b) {
        return true;
    }
    return false;
};

let returnedArray = filter(sourceArr, validator);

console.log(returnedArray);

