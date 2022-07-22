/**
 * @param {character[][]} board
 * @return {boolean}
 */
 var isValidSudoku = function(board) {
    const N = board.length
    let rows = new Array(N)
    let cols = new Array(N)
    let boxes = new Array(N)

    for (let i = 0; i < N; i++) {
        rows[i] = new Set()
        cols[i] = new Set()
        boxes[i] = new Set()
    }

    for (let i = 0; i < N; i++) {
        for (let j = 0; j < N; j++) {
            let item = board[i][j]
            let box = getBox(i,j)
            if(item == ".") continue
            if(rows[i].has(item)) return false
            if(cols[j].has(item)) return false
            if(boxes[box].has(item)) return false

            rows[i].add(item)
            cols[j].add(item)
            boxes[box].add(item)
        } 
    }
  
    return true
};
var getBox = function(x,y){
    if(0 <= x && x <= 2){
        if(0 <= y && y <= 2) return 0
        else if(3 <= y && y <= 5) return 1
        else return 2
    }
    else if(3 <= x && x <= 5){
        if(0 <= y && y <= 2) return 3
        else if(3 <= y && y <= 5) return 4
        else return 5
    }
    else{
        if(0 <= y && y <= 2) return 6
        else if(3 <= y && y <= 5) return 7
        else return 8
    }
};