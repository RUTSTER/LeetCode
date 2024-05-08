/**
 * @param {Function} fn
 * @return {Function}
 */
var once = function(fn) {
    let isAbleToCall = true;

    return function(...args) {
        if (isAbleToCall) {
            isAbleToCall = false;
            return fn(...args);
        }

        return undefined;
    }
};


let fn = (a,b,c) => (a + b + c)

let onceFn = once(fn)

console.log(onceFn(1, 2, 3));
console.log(onceFn(1, 2, 3));
console.log(onceFn(1, 2, 3));
