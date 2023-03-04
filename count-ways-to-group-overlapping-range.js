/**
 * @param {number[][]} ranges
 * @return {number}
 */
var countWays = function(ranges) {
    let ub = Array(ranges.length).fill(0);
    return countWaysAux(ranges, 0, ub);
};

var countWaysAux = function(ranges, index, ubication) {
    if(index == ranges.length) {
        console.log(' ub : ' + JSON.stringify(ubication))
        return 1;
    } 

    if(ubication[index] == 0){
        let ways = 0;

        ubication[index] = 1;
        ways += countWaysAux(ranges, index, ubication);
        ubication[index] = 2;
        ways += countWaysAux(ranges, index, ubication);
        return ways;
    } else {
        for (let i = index + 1; i < ranges.length; i++) {
            if(areOverlapping(ranges[index], ranges[i])) {
                if(ubication[i] == 0) ubication[i] = ubication[index];
                else if(ubication[i] != ubication[index]) {
                    ubication[index] = 0;
                    return 0;
                }
            }
        }

        let thisway = countWaysAux(ranges, index + 1, ubication);
        ubication[index] = 0;
        return thisway;
    }
}

var areOverlapping = function(rg1, rg2) {
    return rg1[1] <= rg2[0] || rg2[1] <= rg1[0];
}