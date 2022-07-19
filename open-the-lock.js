/**
 * @param {string[]} deadends
 * @param {string} target
 * @return {number}
 */
 var openLock = function(deadends, target) {
    var calculateNext = function(char, mov){
       return String.fromCharCode(char.charCodeAt(0) + mov); 
    }
    
    var openLockAux = function(node, steps){
        if(node == target) return steps;
        if(deadends.includes(node)) return Infinity;
        let sol = Infinity
        
        for(let i = 0; i < 4; i++){
            let newNode = node.slice(0, i) + calculateNext(node[i]) + node.slice(i+1, 4);
            let ans1 = openLockAux(newNode, steps + 1)
            sol = Math.min(sol, ans1)

            newNode = node.slice(0, i) + calculateNext(node[i], -1) + node.slice(i+1, 4);
            ans1 = openLockAux(newNode, steps + 1)
            sol = Math.min(sol, ans1)
        }
    }

    let answer = openLockAux('0000', 0);
    answer = answer == Infinity ? -1 : answer
    
    return answer
};