/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
 var wordBreak = function(s, wordDict) {
    let falsePaths = new Set()
    let path = []
    
    var aux = function(idx){
        if(idx == s.length) return true

        for (let i = 0; i < wordDict.length; i++) {
            let word = wordDict[i]
            //console.log(`next: ${s.slice(idx, word.length)}  word: ${word}  idx: ${idx}`)
            if(s.slice(idx, idx + word.length) == word && !falsePaths.has((idx, i))){
                path.push(i)
                let ans = aux(idx + word.length)
                if(ans) return ans
                falsePaths.add((idx,i))
                path.pop()
            }
        }

        return false
    }

    return aux(0, [])
};