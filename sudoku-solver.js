/**
 * @param {character[][]} board
 * @return {void} Do not return anything, modify board in-place instead.
 */
 var solveSudoku = function(board) {
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
      if(board[i][j] != "."){
        let bx = getBox(i,j)
        rows[i].add(board[i][j])
        cols[j].add(board[i][j])
        boxes[bx].add(board[i][j])
      }
    } 
  }

  var aux = function(x, y){
    let next = null    
    for (let i = x; i < N && next==null; i++) {
        for (let j = 0; j < N && next==null; j++)  if(board[i][j] == '.') next = [i,j]
    }

    if(next == null) return true

    for (let i = 1; i < N+1; i++) {
      let row = rows[next[0]].has(i.toString())
      let col = cols[next[1]].has(i.toString())
      let boxNo = getBox(next[0], next[1])
      let box = boxes[boxNo].has(i.toString())
      if(!col && !row && !box){
          board[next[0]][next[1]] = i.toString()
          rows[next[0]].add(i.toString())
          cols[next[1]].add(i.toString())
          boxes[boxNo].add(i.toString())
          if(aux(next[0], next[1])) return true
          board[next[0]][next[1]] = '.'
          rows[next[0]].delete(i)
          cols[next[1]].delete(i)
          boxes[boxNo].delete(i)
      }
    }
    return false
  }

  aux(0,0)

  return board
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