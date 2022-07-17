/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
 var threeSumClosest = function(nums, target) {
	nums.sort((a,b) => a-b)
    let answer = Infinity

	for(let i=0; i< nums.length - 2; i++){
        if(i > 0 && nums[i] === nums[i-1]) continue
		let left = i+1, right = nums.length-1
		while(left < right){
			const sum = nums[i] + nums[left] + nums[right];
            if(sum == target) return target;
            
            answer = Math.abs(target - sum) < Math.abs(target - answer) ? sum : answer;

			if(sum < target){
				left++;
				while(left < right && nums[left] === nums[left-1]) left++
			}else{
				right--;
                while(left < right && nums[right] === nums[right+1]) right--
			}
		}
	}

	return answer
};