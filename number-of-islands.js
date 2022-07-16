/**
 * @param {character[][]} grid
 * @return {number}
 */
 var numIslands = function(grid) {
    let answer = 0; 
    let seen = newBiArray(grid.length, grid[0].length);
    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid[0].length; j++) {
            if(area(i, j, grid, seen) > 0) answer++;
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
 * @param {number[][]} grid
 * @param {boolean[][]} seen 
 * @return {number}
 */
var area = function(r, c, grid, seen){
    if(r < 0 || c < 0 || r == grid.length || c == grid[0].length || grid[r][c] == "0" || seen[r][c]) return 0;

    seen[r][c] = true;
    return 1 + area(r, c-1, grid, seen) + area(r-1, c, grid, seen) + area(r, c+1, grid, seen) + area(r+1, c, grid, seen);
}