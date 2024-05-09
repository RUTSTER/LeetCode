// Overengineering
// Idea - avoid unnecessary allocations to enhance execution speed and reduce memory usage.
// Result - suck in both.

/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function(arr, size) {
    let chunkedLength = Math.floor(arr.length / size)
    chunkedLength += arr.length % size === 0 ? 0 : 1;
    let chunked = new Array(chunkedLength);

    for (let i = 0; i < arr.length; i++) {
        chI = Math.floor(i / size)
        if (i % size === 0) {
            let remainingElements = arr.length - i - 1;
            let newChunkSize = remainingElements < size ? remainingElements : size
            chunked[chI] = new Array(newChunkSize)
        }

        chunked[chI][i % size] = arr[i];
    }

    return chunked;
};



let arr = [ 1, 9, 6, 3, 2 ];
let size = 3;


console.log(chunk(arr, size));
