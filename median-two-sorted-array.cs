public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length==0 && nums2.Length==0) return 0;

    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2, int i11, int i12, int i21, int i22){
        if(index1==-1 && index2-1) return 0;
        else if(index1==-1 && index2!=-1){
            if(nums2.Length%2==0) return (nums2[index2]+nums2[index2])/2;
            else return nums2[index2];
        }
        else if(index1!=-1 && index2==-1){
            if(nums1.Length%2==0) return (nums1[index1]+nums1[index1])/2;
            else return nums1[index1];
        }
        else{
            int pos1 = i11 + i12;
            int median1 = pos1%2==0 ? nums1[pos1/2] : (nums1[(pos1-1)/2]+nums1[(pos1+1)/2])/2;
            int pos2 = i21 + i22;
            int median2 = pos2%2==0 ? nums2[pos2/2] : (nums2[(pos2-1)/2]+nums2[(pos2+1)/2])/2;

            if(median1==median2){
                
            }
        }
    }
}