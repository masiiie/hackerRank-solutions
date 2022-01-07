// https://leetcode.com/problems/move-zeroes/

using System;
public class Solution {
    public void MoveZeroes(int[] nums) {
        int i=0;
        int j=1;
        while(true){
            while(i<nums.Length && nums[i]!=0) i++;
            j=i+1;
            while(j<nums.Length && nums[j]==0) j++;
            if(j>=nums.Length) break;
            nums[i]=nums[j];
            nums[j]=0;
            i++;
            j++;
        }
    }

    public static string printArray<T>(T[] array){
        string sol = "{ ";
        foreach(T item in array) sol+=item.ToString()+" ";
        return sol+"}";
    }
}