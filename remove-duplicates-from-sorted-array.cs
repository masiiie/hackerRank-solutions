// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

using System;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int total = 0;
        int lastDifferent = 1;
        
        for(int i=0;i<nums.Length;i++){
            for(int j=lastDifferent;j<nums.Length && i<lastDifferent;j++){
                Console.WriteLine("i={0} j={1}",i,j);
                if(nums[i]==nums[j]){
                    nums[j]=-1;
                    total++;
                }
                else{
                    nums[i+1]=nums[j];
                    nums[j]=-1;
                    lastDifferent = j+1;
                    break;
                }
            }
        }
        return nums.Length-total;
    }
}