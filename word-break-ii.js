/**   
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
 var wordBreak = function(s, wordDict) {
    let falsePaths = new Set()
    let path = []
    let solutions = []
    
    var aux = function(idx, current){
        if(idx == s.length){
            solutions.push(current.slice(0, -1))
            return true
        }

        let finalAns = false

        for (let i = 0; i < wordDict.length; i++) {
            let word = wordDict[i]
            if(s.slice(idx, idx + word.length) == word && !falsePaths.has(idx + word.length)){
                path.push(i)
                let ans = aux(idx + word.length, current.concat(word.concat(' ')))
                if(ans) finalAns = true
                if(!ans) falsePaths.add(idx + word.length)
                path.pop()
            }
        }

        return finalAns
    }

    aux(0, '')
    return solutions
};