public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length==0 && nums2.Length==0) return 0;

    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2, int index1, int index2){
        if(index1==-1 && index2-1) return 0;
        else if(index1==-1 && index2!=-1){
            if(nums2.Length%2==0) return (nums2[index2]+nums2[index2])/2;
            else return nums2[index2];
        }
        else if(index1!=-1 && index2==-1){
            if(nums1.Length%2==0) return (nums1[index1]+nums1[index1])/2;
            else return nums1[index1];
        }
    }
}