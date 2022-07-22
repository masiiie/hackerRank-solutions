/**
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
 var uniquePaths = function(m, n) {
    let seen = new Array(m);
    for (var i = 0; i < m; i++) seen[i] = new Array(n).fill(0);
     
    
    var aux = function(x,y,pos1,pos2){
        if(pos1 == m || pos2 == n) return 0
        if(seen[pos1][pos2]) return seen[pos1][pos2]
        if(x==0) return 1
        if(y==0) return 1


        seen[pos1][pos2] = aux(x-1, y, pos1 + 1, pos2) + aux(x, y-1, pos1, pos2 + 1)

        return seen[pos1][pos2]
    }

    return aux(m-1, n-1, 0, 0, 1)
};