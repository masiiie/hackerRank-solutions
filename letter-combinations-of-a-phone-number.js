/**
 * @param {string} digits
 * @return {string[]}
 */
 var letterCombinations = function(digits) {
    return letterCombinationsAux(digits, 0)
};


var letterCombinationsAux = function(digits, index) {
    if(index == digits.length) return []
    
    const options = [
        [["a"], ["b"], ["c"]],
        [["d"], ["e"], ["f"]],
        [["g"], ["h"], ["i"]],
        [["j"], ["k"], ["l"]],
        [["m"], ["n"], ["o"]],
        [["p"], ["q"], ["r"], ["s"]],
        [["t"], ["u"], ["v"]],
        [["w"], ["x"], ["y"], ["z"]],
    ]
    
    let restAnswer = letterCombinationsAux(digits, index + 1)
    let combs = options[Number(digits[index])-2]
    if(restAnswer.length == 0){
        if(digits.length == 1) return combs.map(x => x[0])
        return combs
    }
    let final = []
    for(let i = 0; i < combs.length; i++){
        final = final.concat(restAnswer.map(x => `${combs[i]}${x}`))
    }
    return final
}