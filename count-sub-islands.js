/**
 * @param {number[][]} grid1
 * @param {number[][]} grid2
 * @return {number}
 */
 var countSubIslands = function(grid1, grid2) {
    let answer = 0; 
    // No hay array booleano porque los visitados se marcan en grid2 con un 2
    var area = function(r, c){
        if(r < 0 || c < 0 || r == grid1.length || c == grid1[0].length || grid2[r][c] != 1) return 0;
    
        grid2[r][c] = 2; 
        return (grid1[r][c] === 1 ? 0 : 1) + area(r, c-1) + area(r-1, c) + area(r, c+1) + area(r+1, c);
    }

    for (let i = 0; i < grid1.length; i++) {
        for (let j = 0; j < grid1[0].length; j++) {
            if(grid2[i][j] === 1 && area(i, j) === 0) answer++;
        }
    }    
    return answer;
};