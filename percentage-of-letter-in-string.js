/**
 * @param {string} s
 * @param {character} letter
 * @return {number}
 */
 var percentageLetter = function(s, letter) {
    let freq = 0
    for (let i = 0; i < s.length; i++) {
        if(s[i]==letter) freq++ 
    }

    return Math.floor(freq*100/s.length)
};