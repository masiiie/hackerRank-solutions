public class Solution {
    public int[] SortedSquares(int[] nums) {
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(Math.Abs(nums[j])<Math.Abs(nums[i])){
                    int temp = nums[i];
                    nums[i]=nums[j];
                    nums[j]=temp;
                }
            }
            nums[i]=nums[i]*nums[i];
        }
        return nums;
    }
}