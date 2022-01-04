// https://leetcode.com/problems/relative-sort-array/

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int index = 0;
        int lastI = -1;
        for(int i=0;i<arr1.Length && index<arr2.Length;i++){
            if(arr1[i]==arr2[index]) continue;
            else{
                for(int j=i+1;j<arr1.Length;j++){
                    if(arr1[j]==arr2[index]){
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                        while(arr1[i]==arr2[index]) i++;
                    }
                }            
                if(arr1[i]!=arr2[index]) i--;
                index++;
            }
            lastI=i;
        }

        if(lastI<arr1.Length-1 && index>=arr2.Length){
            for(int i=lastI+1;i<arr1.Length;i++){
                for(int j=i+1;j<arr1.Length;j++){
                    if(arr1[j]<arr1[i]){
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
        }

        return arr1;
    }
}