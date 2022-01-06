// https://leetcode.com/contest/weekly-contest-274/problems/maximum-employees-to-be-invited-to-a-meeting/
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //int[] favorite = new int[4]{2,2,1,2};  //ok
        //int[] favorite = new int[3]{1,2,0};   //ok
        //int[] favorite = new int[5]{3,0,1,4,1};    //ok
        //int[] favorite = new int[5]{2,0,1,2,3}; //ok
        int[] favorite = new int[7]{2,6,3,2,3,4,5}; //wrong
        Console.WriteLine(solution.MaximumInvitations(favorite));
    }
}
public class Solution {

    public int MaximumInvitations(int[] favorite) {
        
        for(int size=favorite.Length;size>1;size--){
            int[] asientos = new int[size];
            bool[] puesto = new bool[favorite.Length];
            Array.Fill(asientos,-1);
            Console.WriteLine("size={0}     asientos={1}     puesto={2}", size,printArray(asientos),printArray(puesto));
            for(int i=0;i<favorite.Length;i++){
                asientos[0]=i;
                puesto[i]=true;
                if(MaximumInvitations(favorite, asientos, 1, puesto)) return size;
                puesto[i]=false;
            }
        }
        return 1;
    }

    public static string printArray<T>(T[] array){
        string sol = "{ ";
        foreach(T item in array) sol+=item.ToString()+" ";
        return sol+"}";
    }

    public bool MaximumInvitations(int[] favorite, int[] asientos, int index, bool[] puesto){
        if(index==asientos.Length){
            int fav = favorite[asientos[asientos.Length-1]];
            return fav==asientos[0] || fav==asientos[index-2];
        }
        Console.WriteLine("     index={0}       asientos={1}        puesto={2}",index,printArray(asientos),printArray(puesto)); 
        int cand = favorite[asientos[index-1]];
        if(index-2>-1 && asientos[index-2]==cand){
            for(int i=0;i<puesto.Length;i++){
                if(!puesto[i]){
                    asientos[index]=i;
                    puesto[i]=true;
                    bool solution = MaximumInvitations(favorite,asientos,index+1,puesto);
                    if(solution) return true;
                    puesto[i]=false;
                    asientos[index]=-1;
                }
            }
        }
        else if(!puesto[cand]){
            asientos[index]=cand;   
            puesto[cand]=true;
            bool solution = MaximumInvitations(favorite,asientos,index+1,puesto);
            asientos[index]=-1;
            puesto[cand]=false;
            return solution;
        }
        
        return false;
    }
}