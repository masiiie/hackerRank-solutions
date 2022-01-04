// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int total = 0;
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==-1) nums[i] = i+total<nums.Length ? nums[i+total] : -1;
            for(int j=i+Math.Max(1,total);j<nums.Length;j++){
                if(nums[i]==nums[j]){
                    nums[j]=-1;
                    total++;
                }
                else break;
            }
        }
        return nums.Length-total;
    }
}