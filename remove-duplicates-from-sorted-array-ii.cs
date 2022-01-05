using System;
public class Solution {
    public static string printArray(int[] array){
        string sol = "{ " + array[0].ToString();
        for(int i=1;i<array.Length;i++) sol+=", "+array[i].ToString();
        return sol+" }";
    }
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length==1) return 1;
        
        int repeat = 1;
        int i = 0;
        int j = 1;

        while(j<nums.Length){
            Console.WriteLine("i={0}    j={1}   repeat={2}",i,j,repeat);
            Console.WriteLine("nums={0}",printArray(nums));
            Console.WriteLine();
            if((nums[i]==nums[j] && repeat==1) || nums[i]!=nums[j]){
                if(repeat==1) repeat=0;
                else if(nums[i]!=nums[j]) repeat=1;
                i++;
                nums[i]=nums[j]; 
            }
            if(i<j) nums[j]=-1;
            j++;
        }
        
        return i+1;
    }
}