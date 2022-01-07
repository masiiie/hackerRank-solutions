using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        /*
        int[][] trips = new int[][]{
            new int[]{2,1,5},
            new int[]{3,3,7},
            new int[]{5,7,8}
        };
            // Ok!!
        */

        int[][] trips = new int[][]{
            new int[]{1,1,5},
            new int[]{1,1,5},
            new int[]{2,2,7},
            new int[]{3,3,7},
            new int[]{5,7,8}
        };

        Console.WriteLine(solution.CarPooling(trips,5));  
    }
}

public class Solution {
    public static string printArray<T>(T[] array){
        string sol = "{ ";
        foreach(T item in array) sol+=item.ToString()+" ";
        return sol+"}";
    }
    public bool CarPooling(int[][] trips, int capacity) {
        Comparer1 comp1 = new Comparer1(); Comparer2 comp2 = new Comparer2(); 

        Array.Sort(trips, comp1);
        List<int[]> pickUp = new List<int[]>(trips);
        Array.Sort(trips, comp2);
        List<int[]> pickDrop = new List<int[]>(trips);

        int up = 0;
        int drop = 0;
        int avaiable = capacity;

        while(up<pickUp.Count){
            //Console.WriteLine("up={0}   pickUp={1}",up,printArray(pickUp[up]));
            //Console.WriteLine("drop={0} pickDrop={1}",drop,printArray(pickDrop[drop]));
            //Console.WriteLine("avaiable={0}",avaiable);
            
            avaiable-=pickUp[up][0]; up++;
            if(avaiable<0) return false;
            else if(up==pickUp.Count) return true;
            
            while(pickDrop[drop][2]<=pickUp[up][1]){
                avaiable+=pickDrop[drop][0];
                drop++;
            }
            //Console.WriteLine();
        }
        return true;
    }
}

public class Comparer1 : IComparer<int[]>
{
    public int Compare(int[] a, int[] b)
    {
        if (a[1]==b[1]) return 0;
        else if(a[1]<b[1]) return -1;
        else return 1;
    }
}

public class Comparer2 : IComparer<int[]>
{
    public int Compare(int[] a, int[] b)
    {
        if (a[2]==b[2]) return 0;
        else if(a[2]<b[2]) return -1;
        else return 1;
    }
}