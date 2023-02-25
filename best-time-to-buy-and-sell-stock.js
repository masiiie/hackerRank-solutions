/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let min = Number.MAX_VALUE;
    let mxPr = 0;
    for (let i = 0; i < prices.length; i++) {
        if(prices[i] < min) min = prices[i];
        if(prices[i] - min > mxPr) mxPr = prices[i] - min;
    }
    return mxPr;
};