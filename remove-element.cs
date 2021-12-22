// https://leetcode.com/problems/remove-element/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int lastnull = -1;
        for(int i = 0; i<nums.Length; i++){
            if(nums[i] == val){
                if(lastnull == -1) lastnull = i;
                nums[i] = -1;
            }
            else{
                k += 1;
                if(lastnull!=-1){
                    int change = nums[i];
                    nums[lastnull] = change;
                    nums[i] = -1;
                    lastnull+=1;
                }
            }
        }   
        return k;
    }
}