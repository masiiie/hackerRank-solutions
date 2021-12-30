public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length==0 && nums2.Length==0) return 0;

    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2, int i11, int i12, int i21, int i22){
        /*
            Casos base: los i11>i12
            indices negativos o indices mayores q el length del array
        */ 

        if(i11==i12 && i21==i22) return Math.Min(nums1[i11],nums2[i21]);
        else if(i11!=i12 && i21==i22) return Math.Min(nums1[i11],nums2[i21]);

        int pos1 = i11 + i12;
        int pos2 = i21 + i22;

        int median1pos = pos1%2==0 ? pos1/2 : (pos1-1)/2;
        int median2pos = pos2%2==0 ? pos2/2 : (pos2-1)/2; 

        int median1 = nums1[median1pos];
        int median2 = nums2[median2pos];



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
            if(median1==median2){
                if(pos1%2 != 0 && pos2%2 != 0){
                    int next1 = nums1[median1pos+1];
                    int next2 = nums2[median2pos+1];

                    if(next1<=next2) return (median1+next1)/2;
                    else return (median1+next2)/2;
                }
                else return median1;
            }
            else if(median1<median2){
                int stepsAdded = (median1pos-i11)+1;
                return FindMedianSortedArrays(nums1, nums2, median1pos+1, i12, Math.Max(i21-stepsAdded, 0), Math.Max(i22-stepsAdded, 0));
            }
            else{
                int stepsAdded = (median2pos-i21)+1;
                return FindMedianSortedArrays(nums1, nums2, Math.Max(i11-stepsAdded), Math.Max(i12-stepsAdded), median2pos+1, i22);
            }
        }
    }
}

/*
if(pos1%2 == 0 && pos2%2 == 0) return median1;
else if(pos1%2 != 0 && pos2%2 != 0){
    int next1 = nums1[(pos1+1)/2];
    int next2 = nums2[(pos2+1)/2];

    if(next1==next2) return (median1+next1)/2;
    else if(next1<next2) return (median1+next1)/2;
    else return (median1+next2)/2;
}
else if(pos1%2 != 0 && pos2%2 == 0) return median2;
else return median1; // if(pos1%2 == 0 && pos2%2 != 0)
*/