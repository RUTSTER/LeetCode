/**
 * @param {string} val
 * @return {Object}
 */
var expect = function(val) {
    return {
        expected: val,
        
        toBe: function (actual) {
            if (this.expected === actual) {
                return true;
            }

            throw "Not Equal";
        },

        notToBe: function (actual) {
            if (this.expected !== actual) {
                return true;
            }

            throw "Equal";
        }
    };
};


let e = expect("qwer");


console.log(e.toBe("qwer"));

try {
    console.log(e.notToBe("qwer"));
}
catch (err) {
    console.log(err);
}


try {
    console.log(e.toBe("zxcv"));
}
catch (err) {
    console.log(err);
}

console.log(e.notToBe("zxcv"));
