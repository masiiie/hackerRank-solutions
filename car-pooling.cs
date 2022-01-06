public class Solution {
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
            avaiable-=pickUp[up][0]; up++;
            if(avaiable<0) return false;
            else if(up==pickUp.Count) return true;
            
            if(pickDrop[drop][2]<pickUp[up][1]){
                avaiable+=pickDrop[drop][0];
                drop++;
            }
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