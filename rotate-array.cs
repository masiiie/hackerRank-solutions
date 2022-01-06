// https://leetcode.com/problems/rotate-array/

public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] sol = new int[nums.Length];
        for(int i=0;i<nums.Length;i++) sol[i]= i-k<0 ? nums[nums.Length-k] : nums[i-k];
        nums=sol;
    }
}