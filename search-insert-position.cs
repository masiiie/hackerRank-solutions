// https://leetcode.com/problems/search-insert-position/
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>=target) return i;
        }
        return nums.Length;
    }
}