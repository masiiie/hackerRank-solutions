/**
 * @param {number} n
 * @return {string[]}
 */
 var generateParenthesis = function(n) {
    let sol = []
    generateParenthesisAux(sol, [], 0, 0, n)
    return sol
  };
  
  
  var generateParenthesisAux = function(listAnswer, current, open,  close, max) {
      if(current.length == max*2) listAnswer.push(current.join(''))
      else{
          if(open < max){
              current.push("(")
              generateParenthesisAux(listAnswer, current, open + 1, close, max)
              current.pop()
          }
          if(close < open){
              current.push(")")
              generateParenthesisAux(listAnswer, current, open, close + 1, max)
              current.pop()
          }
      }
  };