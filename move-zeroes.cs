// https://leetcode.com/problems/move-zeroes/

using System;
public class Solution {
    public void MoveZeroes(int[] nums) {
        int i=0;
        int j=1;
        while(i<j && j<nums.Length){
            while(nums[i]!=0) i++;
            j=i+1;
            while(nums[j]==0) j++;
            Console.WriteLine("i={0} j={1}    nums={2}",i,j,printArray(nums));
            nums[i]=nums[j];
            nums[j]=0;
        }
    }

    public static string printArray(int[] array){
        string sol = "{ " + array[0].ToString();
        for(int i=1;i<array.Length;i++) sol+=", "+array[i].ToString();
        return sol+" }";
    }
}