/**
 * @param {number} n
 * @return {number}
 */
var coloredCells = function(n) {
    if(n==1) return 1;
    return coloredCells(n-1) + 4*(n-1)
};