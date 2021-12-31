using System;
using System.Collections.Generic;

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
        int[,] candidatos = new int[2,3];
        int totalLen = nums1.Length + nums2.Length;
        int umbral = totalLen%2!=0 ? (totalLen-1)/2 : totalLen/2;
        
        Func<int,int,bool> descartado = (int menores,int mayores) => {
            return menores>umbral || mayores>umbral || menores<0 || mayores<0;
        };   

        Func<int,int,bool> isMedian = (int menores,int mayores) => {
            return (menores+mayores+1)==totalLen && Math.Abs(mayores-menores)<=1;
        }; 


        int i11 = 0;    int i12=nums1.Length-1;
        int i21 = 0;    int i22=nums2.Length-1;


        while(true){
            int posmedian1 = (i11 + i12)/2;
            int posmedian2 = (i21 + i22)/2;
            if(descartado(candidatos[0,1], candidatos[0,2])){
                               
            }
        }
    }
}