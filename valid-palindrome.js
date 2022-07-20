/**
 * @param {string} s
 * @return {boolean}
 */
 var isPalindrome = function(s) {
    s = s.replace(/[^a-z0-9]/gi, '');
    s = s.toLowerCase()
    var aux = function(x){
        if(x.length < 2) return true
        if(x[0] != x[x.length -1]) return false
        return aux(x.slice(1,x.length-1))
    }

    return aux(s)
};