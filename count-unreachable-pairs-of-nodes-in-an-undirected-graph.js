/**
 * @param {number} n
 * @param {number[][]} edges
 * @return {number}
 */
 var countPairs = function(n, edges) {
    let nodeMap = {};
    for (let i = 0; i < edges.length; i++) {
        let a = edges[i][0];
        let b = edges[i][1];
        if(!nodeMap[a]) nodeMap[a] = [];
        if(!nodeMap[b]) nodeMap[b] = []; 

        nodeMap[a].push(b);
        nodeMap[b].push(a);
    }

    let seen = new Array(n);
    var dfs = function(node){
        if(seen[node]) return 0;

        seen[node] = true;

        let sol = 0;
        if(nodeMap[node]) nodeMap[node].forEach(cn => sol += dfs(cn));
        return sol + 1;
    }

    let gps = []
    for (let i = 0; i < n; i++) {
        if(!seen[i]) gps.push(dfs(i));
    }

    let answer = 0;
    for (let i = 0; i < gps.length; i++) {
        for (let j = i+1; j < gps.length; j++) {
            answer += gps[i]*gps[j]; 
        } 
    }

    return answer;
};