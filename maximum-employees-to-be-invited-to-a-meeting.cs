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

    public static string printArray<T>(T[] array){
        string sol = "{ " + array[0].ToString();
        for(int i=1;i<array.Length;i++) sol+=", "+array[i].ToString();
        return sol+" }";
    }

    public bool MaximumInvitations(int[] favorite, int[] asientos, int index, bool[] puesto){
        if(index==asientos.Length) return true;
        Console.WriteLine("     index={0}       asientos={1}        puesto={2}",
            index,printArray(asientos),printArray(puesto));
        int cand1 = index-1<0 ? favorite[favorite.Length-1] : favorite[index-1];
        if(!puesto[cand1]){
            asientos[index]= cand1;
            puesto[cand1]=true;
            if(MaximumInvitations(favorite, asientos,index+1,puesto)) return true;
            asientos[index]=-1;
            puesto[cand1]=false;
        }

        int cand2 = index+1==favorite.Length ? 0 : favorite[index+1];
        if(cand1!=cand2 && !puesto[cand2]){
            asientos[index] = cand2;
            puesto[cand2] = true;
            if(MaximumInvitations(favorite,asientos,index+1,puesto)) return true;
            asientos[index]=-1;
            puesto[cand2]=false;
        }
        return false;
    }
}