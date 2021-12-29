public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = -1;
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
            for(int j=0; j<i-1;j++){
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