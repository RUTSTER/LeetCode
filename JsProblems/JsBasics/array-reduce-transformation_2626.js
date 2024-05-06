/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {
    let accum = init;

    for (let i = 0; i < nums.length; i++) {
        accum = fn(accum, nums[i]);        
    }

    return accum;
};


let sourceArr = [1, 3, 5, 6];
let sumFunc = function(a, b) {
    return a + b;
};

let returnedArray = reduce(sourceArr, sumFunc, 0);

console.log(returnedArray);
