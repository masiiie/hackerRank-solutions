/**
 * @param {string} s
 * @return {number}
 */
 var firstUniqChar = function(s) {
    let freq = {}
    for (let i = 0; i < s.length; i++) {
        if(freq[s[i]] == null) freq[s[i]] = 0
        freq[s[i]]++
    }

    for (let i = 0; i < s.length; i++) {
        if(freq[s[i]] == 1) return i
    }

    return -1
};