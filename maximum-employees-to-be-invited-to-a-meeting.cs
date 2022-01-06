// https://leetcode.com/contest/weekly-contest-274/problems/maximum-employees-to-be-invited-to-a-meeting/
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //int[] favorite = new int[4]{2,2,1,2};
        //int[] favorite = new int[3]{1,2,0};   ok
        //int[] favorite = new int[5]{3,0,1,4,1};   ok
        int[] favorite = new int[5]{2,0,1,2,3};
        Console.WriteLine(solution.MaximumInvitations(favorite));
    }
}
public class Solution {

    public int MaximumInvitations(int[] favorite) {
        
        for(int size=favorite.Length;size>1;size--){
            int[] asientos = new int[size];
            bool[] puesto = new bool[favorite.Length];
            Array.Fill(asientos,-1);
            Console.WriteLine("size={2}     asientos={1}     puesto={2}", 
                size,printArray(asientos),printArray(puesto));
            if(MaximumInvitations(favorite, asientos, 0, puesto)) return size;
        }
        return 1;
    }

    public static string printArray<T>(IEnumerable<T> array){
        string sol = "{ " + array[0].ToString();
        foreach(T item in array) sol+=", "+item.ToString();
        return sol+" }";
    }

    public bool MaximumInvitations(int[] favorite, int[] asientos, int index, bool[] puesto){
        if(index==asientos.Length) return true;
        Console.WriteLine("     index={0}       asientos={1}        puesto={2}",
            index,printArray(asientos),printArray(puesto));
        
    }
}