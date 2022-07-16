/**
 * @param {number[][]} grid1
 * @param {number[][]} grid2
 * @return {number}
 */
 var countSubIslands = function(grid1, grid2) {
    let answer = 0; 
    let seen = newBiArray(grid1.length, grid1[0].length);
    for (let i = 0; i < grid1.length; i++) {
        for (let j = 0; j < grid1[0].length; j++) {
            if(answer, area(i, j, grid1, grid2, seen) > 0) answer++;
        }
    }    
    return answer;
};

var newBiArray = function(r, c){
    var gfg = new Array(r);
    for (var i = 0; i < gfg.length; i++) {
        gfg[i] = new Array(c);
    } 
    return gfg;
}

/**
 * @param {number} r
 * @param {number} c
 * @param {number[][]} grid1
 * @param {number[][]} grid2
 * @param {boolean[][]} seen 
 * @return {number}
 */
var area = function(r, c, grid1, grid2, seen){
    if(r < 0 || c < 0 || r == grid1.length || c == grid1[0].length || grid2[r][c] == 0 || seen[r][c] || grid1[r][c] == grid2[r][c]) return 0;

    seen[r][c] = true; 
    return p + area(r, c-1, grid1, grid2, seen) + area(r-1, c, grid1, grid2, seen) + area(r, c+1, grid1, grid2, seen) + area(r+1, c, grid1, grid2, seen);
}