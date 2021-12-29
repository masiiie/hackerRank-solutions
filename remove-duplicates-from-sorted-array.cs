// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        //int[] nums = new int[10]{0,0,1,1,1,2,2,3,3,4};
        int[] nums = new int[3]{1,1,2};
        Console.WriteLine(sol.RemoveDuplicates(nums));
        for(int i =0;i<nums.Length;i++){
            Console.Write(nums[i]);
        }
    }
}

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        int maxValue = nums[0];
        int lastCompareIndex = 0;
        
        for(int i=1;i<nums.Length;i++){
            if(nums[i]<=maxValue){
                nums[i]=-1;
                k++;
            }
            else{
                maxValue = nums[i];
                lastCompareIndex++; 
                nums[lastCompareIndex] = nums[i];
                nums[i] = -1;
            }
        }
        return k;
    }
}