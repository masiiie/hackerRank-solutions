/**
 * @param {number[][]} obstacleGrid
 * @return {number}
 */
 var uniquePathsWithObstacles = function(obstacleGrid) {
    const m = obstacleGrid.length
    const n = obstacleGrid[0].length
    if(obstacleGrid[m-1][n-1] == 1) return 0
    let seen = new Array(m);
    for (var i = 0; i < m; i++) seen[i] = new Array(n).fill(0);
     
    
    var aux = function(pos1,pos2){
        if(pos1 == m || pos2 == n) return 0
        if(obstacleGrid[pos1][pos2] == 1) return 0
    
        if(pos1==m-1 && pos2==n-1) return 1
        if(seen[pos1][pos2]) return seen[pos1][pos2]
        

        seen[pos1][pos2] = aux(pos1 + 1, pos2) + aux(pos1, pos2 + 1)

        return seen[pos1][pos2]
    }

    return aux(0, 0)  
};