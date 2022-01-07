// https://leetcode.com/problems/rotate-array/

public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k%nums.Length;
        int[] auxiliar = new int[nums.Length];

        for(int i=0;i<k;i++){
            auxiliar[i]=nums[i];
            nums[i]=nums[nums.Length+i-k];
        }
        for(int i=k;i<nums.Length;i++){
            auxiliar[i]=nums[i];
            nums[i] = auxiliar[i-k];
        }
    }
}