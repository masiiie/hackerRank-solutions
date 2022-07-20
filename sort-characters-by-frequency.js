/**
 * @param {string} s
 * @return {string}
 */
 var frequencySort = function(s) {
    let count = new Array(s.length + 1)
    let freq = {}
    for (let i = 0; i < s.length; i++) {
        if(freq[s[i]] == null) freq[s[i]] = 0
        if(count[freq[s[i]]] != null) count[freq[s[i]]].delete(s[i])
        freq[s[i]]++
        if(count[freq[s[i]]] == null) count[freq[s[i]]] = new Set()
        count[freq[s[i]]].add(s[i])
    }

    let sol = ''
    for (let i = count.length - 1; i > -1; i--) {
        if(count[i] == null) continue
        for (const its of count[i]) {
            sol = sol.concat(its.repeat(i))   
        }
    }
    return sol
};