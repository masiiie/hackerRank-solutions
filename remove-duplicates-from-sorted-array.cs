// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int lastCompareIndex = 0;
        int k = 0;
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[lastCompareIndex]){
                nums[i]=-1;
                k++;
            }
            else{
                lastCompareIndex++;
                nums[lastCompareIndex] = nums[i];
            }
        }
        return k;
    }
}