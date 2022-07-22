/**
 * @param {number[][]} grid
 * @return {number}
 */
 var uniquePathsIII = function(grid) {
    const m = grid.length
    const n = grid[0].length
    let seenPath = new Array(m)
    for (var i = 0; i < m; i++) seenPath[i] = new Array(n).fill(false);
    
    let x = 0, y = 0, totalFree = 0

    for (let i = 0; i < m; i++) {
        for (let j = 0; j < n; j++) {
            if(grid[i][j] == 1) x = i, y = j
            if(grid[i][j] == 0) totalFree++
        }
    }
     
    
    var aux = function(pos1,pos2, stepsLeft){
        if(pos1 < 0 || pos2 < 0 || pos1 == m || pos2 == n) return 0
        if(seenPath[pos1][pos2]) return 0
        if(grid[pos1][pos2] == -1) return 0
        if(grid[pos1][pos2] == 2) return stepsLeft == -1 ? 1 : 0;
        

 
        seenPath[pos1][pos2] = true
        const sol = aux(pos1 + 1, pos2, stepsLeft -1) + aux(pos1, pos2 + 1, stepsLeft -1) + aux(pos1 - 1, pos2, stepsLeft -1) + aux(pos1, pos2 - 1, stepsLeft -1) 
        seenPath[pos1][pos2] = false

        return sol
    }

    return aux(x, y, totalFree)    
};