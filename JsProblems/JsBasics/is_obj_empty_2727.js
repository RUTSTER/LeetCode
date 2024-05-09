/**
 * @param {Object|Array} obj
 * @return {boolean}
 */
var isEmpty = function(obj) {
    if(Array.isArray(obj)){
        return obj.length === 0;
    }
    
    return Object.keys(obj).length === 0;
};



let emptyObj = {};
let nonEmptyObj = { x: 1, y: 2, sum: (x, y) => (x + y)};
let emptyArr = [];
let nonEmptyArr = [ 1, 2, (x, y) => (x + y)];

console.log(isEmpty(emptyObj));
console.log(isEmpty(nonEmptyObj));
console.log(isEmpty(emptyArr));
console.log(isEmpty(nonEmptyArr));
