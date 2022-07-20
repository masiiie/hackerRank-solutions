/**
 * @param {number[]} nums
 * @return {number[]}
 */
 var frequencySort = function(nums) {
    let count = {}
    let freq = new Array(nums.length + 1).fill(null);

    for (let i = 0; i < nums.length; i++) {
        count[nums[i]] = count[nums[i]] == undefined ? 0 : count[nums[i]]
        let cNum = count[nums[i]]
        if(freq[cNum] != null) freq[cNum].delete(nums[i])
        count[nums[i]]++
        if(freq[cNum+1] == null) freq[cNum+1] = new Set()
        freq[cNum+1].add(nums[i])
    }

    let sol = []
    for (let i = 1; i < freq.length; i++) {
        if(freq[i] == null) continue
        for (const itm of freq[i]) sol = sol.concat(new Array(i).fill(itm))  
    }
    return sol    
};