class TreeNode {
    constructor(value = key, parent = null) {
        this.value = value;
        this.parent = parent;
    }
}


/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
 var wordBreak = function(s, wordDict) {
    let falsePaths = new Set()
    let path = new TreeNode(-1, null)
    
    var aux = function(idx){
        if(idx == s.length) return true

        for (let i = 0; i < wordDict.length; i++) {
            let word = wordDict[i]
            let newState = 
            if(s.slice(idx, idx + word.length) == word && !falsePaths.has()){
                path.push(i)
                let ans = aux(idx + word.length)
                if(ans) return ans
                falsePaths.add((idx,Array.from(path)))
                path.pop()
            }
        }

        return false
    }

    return aux(0, [])
};