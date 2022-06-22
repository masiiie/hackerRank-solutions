public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int max = Int32.MinValue;
        int[,] sumValues = new int[nums.Length, nums.Length];
        for (int i = 0; i < nums.Length; i++){
            sumValues[i,i] = nums[i];
            if(nums[i] > max) max = nums[i];
        }

        for (int i = 2; i < nums.Length+1; i++)
        {
            for (int j = 0; j+i-1 < nums.Length; j++)
            {
                int currSum = sumValues[j,j+i-2]+nums[j+i-1];
                sumValues[j,j+i-1] = currSum;
                if(currSum > max) max = currSum;
            }
        }
        
        
        for (int i = 1; i < nums.Length-1; i++)
        {
            for (int j = 1; j+i < nums.Length; j++)
            {
                int currSum = sumValues[0, j-1] + sumValues[j+i, nums.Length-1];
                if(currSum > max) max = currSum;
            }
        }
        return max;
    }
}