/**
 * @param {Function} fn
 * @return {Function}
 */
function memoize(fn) {
    let mapArgsToResults = new Map();

    return function(...args) {
        let argsStr = args.toString();

        if (!mapArgsToResults.has(argsStr)) {
            mapArgsToResults.set(argsStr, fn(...args));            
        }

        return mapArgsToResults.get(argsStr);
    }
};




let callCount = 0;
let fn = function (a, b) {	 
    callCount += 1;
    return a + b;
}

let memoizedFn = memoize(fn);

console.log(memoizedFn(2, 3));
console.log(memoizedFn(2, 3));
console.log("callCount = " + callCount);
console.log(memoizedFn(3, 2));
console.log(memoizedFn(3, 2));
console.log("callCount = " + callCount);
