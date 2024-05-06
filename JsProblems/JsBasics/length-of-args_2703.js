/**
 * @param {...(null|boolean|number|string|Array|Object)} args
 * @return {number}
 */
var argumentsLength = function(...args) {
    return args.length;
};


let arguments = [{}, null, "3", x => x - 1];

let res = argumentsLength(...arguments);
console.log(res);
