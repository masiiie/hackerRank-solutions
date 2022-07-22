/**
 * @param {character[][]} board
 * @return {void} Do not return anything, modify board in-place instead.
 */
 var solveSudoku = function(board) {
  const N = board.length

  var aux = function(x, y){
    let next = null    
    for (let i = x; i < N && next==null; i++) {
        for (let j = 0; j < N && next==null; j++)  if(board[i][j] == '.') next = [i,j]
    }

    if(next == null) return true

    var quatRows = 0 <= next[0] <= 2 ? [0,2] : 3 <= next[0] <= 5 ? [3,5] : [6,8]
    var quatCols = 0 <= next[1] <= 2 ? [0,2] : 3 <= next[1] <= 5 ? [3,5] : [6,8]

    for (let i = 1; i < N+1; i++) {
        let row = board[next[0]].includes(i.toString())
        let col = board.map(function(value,index) { return value[next[1]]; }).includes(i.toString())
        let box = board.slice(quatRows[0], quatRows[1] + 1).map(function(value,index) { return value.slice(quatCols[0], quatCols[1] + 1); })
        box = box[0].includes(i.toString()) || box[1].includes(i.toString()) || box[2].includes(i.toString())
        if(!col && !row && !box){
            //console.log(`next: ${next.toString()}  i: ${i}`)
            board[next[0]][next[1]] = i.toString()
            if(aux(next[0], next[1])) return true
            board[next[0]][next[1]] = '.'
        }
    }
    return false
  }

  aux(0,0)

  return board
};