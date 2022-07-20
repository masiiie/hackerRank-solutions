/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
 var wordBreak = function(s, wordDict) {
    falsePaths = new Set()
    
    var aux = function(idx, path){
        if(idx == s.length) return true

        for (let i = 0; i < wordDict.length; i++) {
            const word = wordDict[i]
            //console.log(`next: ${s.slice(idx, word.length)}  idx: ${idx}`)
            if(s.slice(idx, word.length) == word && !falsePaths.has((idx, i))){
                path.push(i)
                const ans = aux(idx + word.length, path)
                if(ans) return ans
                falsePaths.add((idx,i))
                path.pop()
            }
        }

        return false
    }

    return aux(0, [])
};