using System;
					
public class Program
{
	public static void Main()
	{
        // 1 1 1 2 2 2 3 6 7 
        /*
        int[] nums1 = new int[3]{1,1,2,3};
        int[] nums2 = new int[4]{1,2,2,6,7};
        ok

        int[] nums1 = new int[3]{1,2,3};
        int[] nums2 = new int[4]{4,5,6,7};
        ok

        int[] nums1 = new int[1]{2};
        int[] nums2 = new int[2]{1,3};
        Console.WriteLine(sol.FindMedianSortedArrays(nums1, nums2));
        ok

        int[] nums1 = new int[1]{2};
        int[] nums2 = new int[2]{1,3};
        Console.WriteLine(sol.FindMedianSortedArrays(nums2, nums1));
        ok

        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[4]{2,3,6,8};
        ok
        */
		Solution sol = new Solution();
        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[5]{2,4,6,8,10};

        double answer = sol.FindMedianSortedArrays(nums1,nums2);
        Console.WriteLine(answer);
	}
}

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m = nums2.Length;
        return FindMedianSortedArrays(nums1, nums2, 0, n-1, 0, m-1, new int[n+m], -1);
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2, int i11, int i12, int i21, int i22, int[] auxiliar, int lastFilled){
        int auxLen = auxiliar.Length;

        if(lastFilled>=(auxLen-1)/2){
            if(auxLen%2==0) return (auxiliar[auxLen/2] + auxiliar[(auxLen/2)-1])/2;
            else return auxiliar[(auxLen-1)/2];
        }

        Console.WriteLine("i11={0} i12={1}", new object[2]{i11,i12});
        Console.WriteLine("i21={0} i22={1}", new object[2]{i21,i22});
        for(int i=0;i<auxLen;i++){
            Console.Write("{0} ", auxiliar[i]);
        }
        Console.WriteLine("lastFilled={0}",lastFilled);
        Console.WriteLine();
        Console.ReadLine();

        int pos1 = i11 + i12;
        int pos2 = i21 + i22;

        int median1pos = pos1%2==0 ? pos1/2 : (pos1-1)/2;
        int median2pos = pos2%2==0 ? pos2/2 : (pos2-1)/2; 

        int median1 = nums1[median1pos];
        int median2 = nums2[median2pos];

        if(median1<=median2){
            for(int i=i11; i<median1pos;i++){
                lastFilled++;
                auxiliar[lastFilled] = nums1[i];
            }
            return FindMedianSortedArrays(nums1, nums2, median1pos, i12, i21, i22, auxiliar, lastFilled);
        }
        else{
            for(int i=i21; i<median2pos;i++){
                lastFilled++;
                auxiliar[lastFilled] = nums2[i];
            }
            return FindMedianSortedArrays(nums1,nums2,i11,i12,median2pos,i22,auxiliar,lastFilled);
        }
    }
}