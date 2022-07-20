/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
 var topKFrequent = function(nums, k) {
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
    for (let i = freq.length-1; i > -1 && sol.length < k; i--) {
        if(freq[i] != null && freq[i].size > 0) sol = sol.concat(Array.from(freq[i]).slice(0, k-sol.length))  
    }
    return sol
};