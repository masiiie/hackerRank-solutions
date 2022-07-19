/**
 * @param {string[]} deadends
 * @param {string} target
 * @return {number}
 */
 var openLock = function(deadends, target) {
    var calculateNext = function(char, mov){
       if(char == '0' && mov == -1) return '9'
       if(char == '9' && mov == 1) return '1'
       return String.fromCharCode(char.charCodeAt(0) + mov); 
    }
    
    let queue = ['0000']
    let visited = new Set(['0000'])
    let turns = 0
    const movs = [1,-1]

    while(queue.length){
        const next = []
        for(let node of queue){
            if(node === target) return turns
            if(deadends.includes(node)) continue
            for(let i = 0; i < 4; i++){
                movs.forEach(mov => {
                    let newNode = node.slice(0, i) + calculateNext(node[i], mov) + node.slice(i+1, 4);
                    if(!visited.has(newNode)){
                        visited.add(newNode)
                        next.push(newNode)
                    }
                })
            }
        }
        turns++
        queue = next
    }
    
    return -1
};