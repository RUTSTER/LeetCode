/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    return function(x) {
        let accum = x;

        for (let i = functions.length - 1; i >= 0; i--) {
            accum = functions[i](accum);
        }

        return accum;
    }
};



let functions = [x => x + 1, x => 2 * x, x => x - 1];

let composed = compose(functions)
let res = composed(5);

console.log(res);
