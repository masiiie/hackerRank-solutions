/**
 * @param {number[]} nums
 * @return {number[][]}
 */
 var threeSum = function(nums) {
    let triplets = [];
    var auxSum = function(index, curr){
        if(curr.length == 3 && curr[0] + curr[1] + curr[2] == 0){
            let contains = false;
            for (let i = 0; i < triplets.length && !contains; i++) {
                const eq = curr.includes(triplets[i][0]) && curr.includes(triplets[i][1]) && curr.includes(triplets[i][2]); 
                if(eq) contains = true;
            }
            if(!contains) triplets.push(curr.slice());
        }
        else{
            if(index == nums.length) return;
            curr.push(nums[index]);
            auxSum(index + 1, curr);
            curr.pop(nums[index]);
            auxSum(index + 1, curr);
        }
    };

    auxSum(0, []);
    return triplets;
};