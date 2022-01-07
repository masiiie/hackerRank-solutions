using System;
public class Solution {
    public static string printArray<T>(T[] array){
        string sol = "{ ";
        foreach(T item in array) sol+=item.ToString()+" ";
        return sol+"}";
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
                if(nums[i]==nums[j] && repeat==1) repeat=0;
                else repeat=1;
                i++;
                nums[i]=nums[j]; 
            }
            if(i<j) nums[j]=-1;
            j++;
        }
        
        return i+1;
    }
}