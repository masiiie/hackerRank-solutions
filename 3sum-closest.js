/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var threeSumClosest = function(nums, target) {
	nums.sort((a,b) => a-b)
    let minDiff = target*Math.pow(10,4)
    let answer = 0

	for(let i=0; i< nums.length; i++){
		let left = i+1
		let right = nums.length-1
		if(i > 0 && nums[i] === nums[i-1]) continue
		while(left < right){
			let sum = nums[i] + nums[left] + nums[right]
            const diff = Math.abs(target - sum) 

			if(diff < minDiff){
                minDiff = diff
                answer = sum
				left++
				while(nums[left] === nums[left-1] && left < right) left++
			}else if(sum > 0){
				right--
			}else{
				left++
			}
		}
	}

	return answer
};