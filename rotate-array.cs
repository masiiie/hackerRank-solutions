// https://leetcode.com/problems/rotate-array/

public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k%nums.Length;
        while(k>0){
            int initial = nums[nums.Length-1];
            for(int i=nums.Length-1;i>0;i--) nums[i]=nums[i-1];
            nums[0]=initial;
            k--;
        }
    }
}