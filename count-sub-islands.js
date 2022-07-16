/**
 * @param {number[][]} grid1
 * @param {number[][]} grid2
 * @return {number}
 */
 var countSubIslands = function(grid1, grid2) {
    let answer = 0; 

    var notCovered = function(r, c){
        if(r < 0 || c < 0 || r == grid1.length || c == grid1[0].length || grid2[r][c] != 1) return 0;
    
        grid2[r][c] = 2; 
        return (grid1[r][c] == grid2[r][c] ? 0 : 1) + notCovered(r, c-1) + notCovered(r-1, c) + notCovered(r, c+1) + notCovered(r+1, c);
    }

    for (let i = 0; i < grid1.length; i++) {
        for (let j = 0; j < grid1[0].length; j++) {
            if(notCovered(i, j) == 0) answer++;
        }
    }    
    return answer;
};