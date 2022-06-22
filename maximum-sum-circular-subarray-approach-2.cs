public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int S = nums[0];
        int globalMax = nums[0];
        int currMax = nums[0];
        for (int i = 1; i < nums.Length; i++){
            currMax = Math.Max(nums[i], nums[i]+currMax);
            globalMax = Math.Max(globalMax, currMax);
            S+=nums[i];
        }

        if(nums.Length == 1) return S;

        int globalMin = nums[1];
        int currMin = nums[1];
        for (int i = 2; i < nums.Length-1; i++){
            currMin = Math.Min(nums[i], nums[i]+currMin);
            globalMin = Math.Min(globalMin, currMin);
        }

        return Math.Max(globalMax, S - globalMin);
    }
}