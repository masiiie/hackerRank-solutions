/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let mxPr = 0;
    for (let i = 0; i < prices.length; i++) {
        for (let j = i+1; j < prices.length; j++) {
            let dif = prices[j] - prices[i];
            if(dif > mxPr) mxPr = dif;
        }  
    }
    return mxPr;
};