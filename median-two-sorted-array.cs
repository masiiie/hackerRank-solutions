using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        /*      
        int[] nums1 = new int[3]{1,2,3};
        int[] nums2 = new int[4]{4,5,6,7};
        ok!!  ~ Cuando compara el 3 con el 4 este ultimo queda (3 y 3) y median(4) da true

        int[] nums1 = new int[1]{2};
        int[] nums2 = new int[2]{1,3};
        ok!!  ~ Se queda vacio un array y el otro con un solo candidato   

        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[5]{2,4,6,8,10};
        ok!!  ~ Se queda vacio un array y el otro con un solo candidato

        int[] nums1 = new int[8]{7,8,8,8,8,8,8,9};
        int[] nums2 = new int[26]{1,1,1,1,1,1,1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9};
        ok!!  ~ Quedan solo 2 candidatos al final

        int[] nums1 = new int[10]{1,1,1,1,1,1,1,1,1,1};
        int[] nums2 = new int[10]{1,1,1,1,1,1,1,1,1,1};
        ok!!

        int[] nums1 = new int[3]{8,8,9};
        int[] nums2 = new int[2]{8,9};
        ok!!

        int[] nums1 = new int[4]{1,2,3,3};
        int[] nums2 = new int[20]{1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9};
        ok!!

        int[] nums1 = new int[4]{7,8,8,9};
        int[] nums2 = new int[20]{1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9};
        ok!!

        int[] nums1 = new int[7]{7,10,21,44,45,46,47};
        int[] nums2 = new int[7]{22,30,31,40,40,40,40};
        ok!!

        int[] nums1 = new int[4]{1,1,2,3};
        int[] nums2 = new int[5]{1,2,2,6,7};  
        ok!!

        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[4]{2,3,6,8}; 
        ok!! 

        int[] nums1 = new int[4]{1,2,3,4};
        int[] nums2 = new int[10]{1,2,3,4,5,6,7,8,8,8};
        ok!!

        int[] nums1 = new int[4]{1,2,3,4};
        int[] nums2 = new int[8]{1,2,3,4,5,6,7,8};
        ok!!

        int[] nums1 = new int[4]{7,10,21,44};
        int[] nums2 = new int[4]{22,30,31,40};
        ok!!
        */
		Solution sol = new Solution();
        int[] nums1 = new int[10]{0,0,0,0,0,1,1,1,1,1};
        int[] nums2 = new int[10]{1,1,1,1,1,1,1,1,1,1};


        double answer = sol.FindMedianSortedArrays(nums1,nums2);
        Console.WriteLine(answer);
	}
}

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[,] options = new int[2,3];
        int totalLen = nums1.Length + nums2.Length;
        int umbral = totalLen%2!=0 ? (totalLen-1)/2 : totalLen/2;
        
        Func<int,int,int> isDeprecated = (int menores,int mayores) => {
            if(menores>umbral) return -1;
            if(mayores>umbral) return 1;
            return 0;
        };   

        Func<int,int,bool> isMedian = (int menores, int mayores) => {
            return (menores+mayores+1)==totalLen && mayores==menores;
        }; 

        Func<int[,], bool> areMedianToguether = (int[,] actualOptions) => {
            int m1 = actualOptions[0,0]; int m2 = actualOptions[1,0];
            int men1 = actualOptions[0,1]; int men2 = actualOptions[1,1];
            int may1 = actualOptions[0,2]; int may2 = actualOptions[1,2];

            if(m1==m2 && men1==may1) return true;
            return false;
        };


        int i11 = 0;    int i12=nums1.Length-1;
        int i21 = 0;    int i22=nums2.Length-1;
        int dep1 = 1; int dep2 = 1; int dep3 = 1;


        while(true){
            int posmedian1 = (i11 + i12)/2;
            int posmedian2 = (i21 + i22)/2;

            Console.WriteLine("i11={0}  i12={1}", new object[2]{i11,i12});
            Console.WriteLine("i21={0}  i22={1}", new object[2]{i21,i22});
            Console.WriteLine();
            //Console.ReadLine();

            if(i11==i12 && i21==i22 && totalLen%2==0) return (double)(nums1[i11]+nums2[i22])/(double)2;
            else if(i11>i12){
                if(totalLen%2==0) return (double)(nums2[posmedian2]+nums2[posmedian2+1])/(double)2;
                else return nums2[posmedian2];
            }
            else if(i21>i22){
                if(totalLen%2==0) return (double)(nums1[posmedian1]+nums1[posmedian1+1])/(double)2;
                else return nums1[posmedian1];
            }
            else if(dep1==0 && dep2==0 && dep3==0 && (i12-i11)+(i22-i21)== 1){
                int along = i11==i12 ? nums1[i11] : nums2[i21];
                int n1 = i11==i12 ? nums2[i21] : nums1[i11];
                int n2 = i11==i12 ? nums2[i22] : nums1[i12];

                if(totalLen%2==0) return along>=n2 ? (double)(n1+n2)/(double)2 : (double)(n1+along)/(double)2;
                else return along>=n2 ? n2 : (along>=n1 ? along : n1);
            }
            
            options[0,0] = nums1[posmedian1];
            options[0,1] = posmedian1;
            options[0,2] = nums1.Length - posmedian1 - 1;

            options[1,0]=nums2[posmedian2];
            options[1,1]=posmedian2;
            options[1,2]=nums2.Length - posmedian2 - 1;

            if(options[0,0]==options[1,0]){
                int t1 = options[0,1] + options[1,1];
                int t2 = options[0,2] + options[1,2];
                options[0,1] = t1;
                options[0,2] = t2;
                options[1,1] = t1;
                options[1,2] = t2;
            }
            else if(options[0,0]<options[1,0]){
                options[1,1]+=1+options[0,1];
                options[0,2]+=1+options[1,2];
            }
            else{
                options[0,1]+=1+options[1,1];
                options[1,2]+=1+options[0,2];
            }

            bool cond1 = isMedian(options[0,1], options[0,2]);
            bool cond2 = isMedian(options[1,1], options[1,2]);
            bool cond3 = areMedianToguether(options);

            if(totalLen%2!=0 && cond1) return options[0,0];
            else if(totalLen%2!=0 && cond2) return options[1,0];
            else if(totalLen%2==0 && cond3) return (double)(options[0,0] + options[1,0])/(double)2;

            dep1 = isDeprecated(options[0,1], options[0,2]);
            dep2 = isDeprecated(options[1,1], options[1,2]);

            dep3 = options[0,0]==options[1,0] && dep1==0 && 
                ((totalLen%2==0 && !cond3) || totalLen%2!=0) ? 1 : 0;

            if(options[0,1]>=umbral) i12=posmedian1+dep1-dep3;
            else if(options[0,2]>=umbral) i11=posmedian1+dep1+dep3;

            if(options[1,1]>=umbral) i22=posmedian2+dep2;
            else if(options[1,2]>=umbral) i21=posmedian2+dep2;
        }
        return Math.Pow(-10, 7);
    }
}