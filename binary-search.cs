public class Solution {
    public int Search(int[] nums, int target) {
        int i=0; int j=nums.Length-1;

        while(i<=j && i>=0 && j<nums.Length){
            int medianpos = (i+j)/2;
            if(target==nums[medianpos]) return medianpos;
            else if(target<nums[medianpos]) j=medianpos-1;
            else i=medianpos+1;
        }
        return -1;
    }
}