
/**
 * @param {number} n
 * @return {Function} counter
 */
var createCounter = function(n) {
    return function(...args) {
        return n++;
    }
};


const c = createCounter(6);
console.log(c());
console.log(c());
console.log(c());
