/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
    return {
        counter: init,
        
        increment: function () {
            this.counter++;
            return this.counter;
        },

        decrement: function () {
            this.counter--;
            return this.counter;
        },

        reset: function () {
            this.counter = init;
            return this.counter;
        }
    };
};


let c = createCounter(5);


console.log(c.increment());
console.log(c.increment());
console.log(c.increment());
console.log(c.decrement());
console.log(c.reset());
console.log(c.decrement());
