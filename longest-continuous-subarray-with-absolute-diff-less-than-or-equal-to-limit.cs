class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        int max = nums[0];
        int min = nums[0];
        int maxLen = 1;
        int currLen = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[i]);

            if(Math.Abs(max-min) <= limit){
                currLen++;
                maxLen = Math.Max(maxLen, currLen);
            }
            else{
                max = nums[i];
                min = nums[i];
                currLen = 1;
            }
        }

        Console.WriteLine("max: {0}, min: {1}", max, min);
        return maxLen;
    }
}