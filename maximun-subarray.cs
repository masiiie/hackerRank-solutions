using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        //int[] array = new int[1]{1};
        //int[] array = new int[5]{5,4,-1,7,8};
        int[] array = new int[2]{-2,1};
        Console.WriteLine(sol.MaxSubArray(array));
    }
}

public class Solution {
    public int MaxSubArray(int[] nums) {
        int[] sumas = new int[nums.Length];
        sumas[0] = nums[0];

        int maxSum = sumas[0];
        int index1 = 0;
        int index2 = 0;

        for(int i=1; i<nums.Length;i++){
            sumas[i] = sumas[i-1]+nums[i];
            if(sumas[i]> maxSum){
                maxSum = sumas[i];
                index2 = i;
            }
        }

        for(int i=nums.Length-1; i>0;i--){
            for(int j=0; j<i;j++){
                int actual = sumas[i]-sumas[j];
                if(actual>maxSum){
                    maxSum = actual;
                    index1 = j+1;
                    index2 = i;
                } 
            }
        }

        return maxSum;
    }
}