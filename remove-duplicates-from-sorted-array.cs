// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

using System;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length==0) return 0;
        int i = 0;
        int j = 1;

        while(j<nums.Length){
            if(nums[i]!=nums[j]){
                i++;
                nums[i]=nums[j];
            }
            else if(i!=j) nums[j]=-1;
            
            j++;
            
        }
        
        return i+1;
    }
}