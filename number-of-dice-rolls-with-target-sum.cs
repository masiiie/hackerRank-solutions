// https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/

public class Solution {
    public int NumRollsToTarget(int n, int k, int target) {
        int sol = 0;
        for(int i=k;i>0;i--){
            int veces = n;
            while(veces>0){
                target-=k;
                veces--;
                if(target==0){
                    sol++;
                    break;
                }
            }
        }
        return sol;
    }

    public int NumRollsToTarget(int n, int k, int target, int actualK, int partialSum){
        if(actualK>k && target==0) return 1;
        
        int sol = 0;
        for(int i=1;i<n+1;i++){
            potencias[actualIndex] = i;
            sol+=NumRollsToTarget(n,k,target,actualIndex+1,potencias);
        }
        sol+=NumRollsToTarget(n,k,target,actualK+1,partialSum);
        return sol;
    }

    public bool suma(int[] potencias, int target)
    {
        int suma = 0;
        for(int i=0;i<potencias.Length;i++) suma+=Math.Pow(i+1,potencias[i]);
        return suma==target;
    } 
}