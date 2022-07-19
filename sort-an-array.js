/**
 * @param {number[]} nums
 * @return {number[]}
 */
 var sortArray = function(nums) {
    if(nums.length == 1) return nums;
     
    const N = Math.trunc(nums.length/2)
    let p1 = sortArray(nums.slice(0, N))
    let p2 = sortArray(nums.slice(N)) 

    return merge(p1, p2)
};


const merge = (l1, l2) => {
    let i = 0
    let j = 0
    let sol = []

    while(i<l1.length && j<l2.length){
        if(l1[i]<l2[j]){
            sol.push(l1[i])
            i++
        }
        else{
            sol.push(l2[j])
            j++
        }
    }

    if(i==l1.length) sol = sol.concat(l2.slice(j))
    else sol = sol.concat(l1.slice(i))
    return sol
}