// https://leetcode.com/problems/remove-element/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for(int i = 0; i<nums.Length; i++){
            int lastnull = -1;
            if(nums[i] == val){
                lastnull = i;
                nums[i] = null;
            }
            else if(lastnull!=-1){
                int change = nums[i];
                nums[lastnull] = change;
                nums[i] = null;
                lastnull+=1;
            }
        }   
    }
}