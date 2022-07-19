/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
 var topKFrequent = function(nums, k) {
    let count = {}
    let freq = new Array(nums.length).fill([]);

    for (let i = 0; i < nums.length; i++) {
        const index = freq[count[nums[i]] - 1].indexOf(nums[i]);
        if(index > -1) freq[count[nums[i]] - 1].splice(index, 1) 
        if(count[nums[i]] == undefined) count[nums[i]] = 0
        count[nums[i]]++

        freq[count[nums[i]] - 1].push(nums[i])
    }

    let sol = []
    for (let i = freq.length-1; i > -1; i++) {
        if(freq[i].length > 0) sol = sol.concat(freq[i])  
    }
    return sol
};