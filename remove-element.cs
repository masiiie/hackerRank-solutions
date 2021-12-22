// https://leetcode.com/problems/remove-element/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for(int i = 0; i<nums.Length; i++){
            if(nums[i] == val){
                nums[i] = null;
                for(int j = 1; j< nums.Length; j++){
                    if(nums[i+j] == val) nums[i+j] = null;
                    else{
                        int change = nums[j];
                        nums[i] = change;
                        nums[j] = null;


                    }
                }
            }
        }   
    }
}