using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        // 1 1 1 2 2 2 3 6 7 
        /*
        int[] nums1 = new int[4]{1,1,2,3};
        int[] nums2 = new int[5]{1,2,2,6,7};
        ok
        

        int[] nums1 = new int[3]{1,2,3};
        int[] nums2 = new int[4]{4,5,6,7};
        ok
        

        int[] nums1 = new int[1]{2};
        int[] nums2 = new int[2]{1,3};
        ok

        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[4]{2,3,6,8};
        

        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[5]{2,4,6,8,10};
        

        Casos problematicos:
            Los arrays son iguales o con diferencia 2.


        int[] nums1 = new int[4]{7,10,21,44};
        int[] nums2 = new int[4]{22,30,31,40};
        // Este caso es super problematico porque deja el array de la izquierda vacio


        int[] nums1 = new int[7]{7,10,21,44,45,46,47};
        int[] nums2 = new int[7]{22,30,31,40,40,40,40};
        // Otro caso problematico xq quedan dos numeros al final q no se descartan y es impo-
        sible que puedan ser mediana juntos xq no quedan contiguos en la ordenacion

        */
		Solution sol = new Solution();
        int[] nums1 = new int[4]{1,3,5,7};
        int[] nums2 = new int[4]{2,3,6,8};

        double answer = sol.FindMedianSortedArrays(nums1,nums2);
        Console.WriteLine(answer);
	}
}

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[,] options = new int[2,3];
        options[0,0] = (int)Math.Pow(-10,7);
        options[1,0] = (int)Math.Pow(-10,7);

        int totalLen = nums1.Length + nums2.Length;
        int umbral = totalLen%2!=0 ? (totalLen-1)/2 : totalLen/2;
        
        Func<int,int,int> isDeprecated = (int menores,int mayores) => {
            if(menores>umbral) return 1;
            if(mayores>umbral) return 2;
            return 0;
        };   

        Func<int,int,bool> isMedian = (int menores,int mayores) => {
            return (menores+mayores+1)==totalLen && Math.Abs(mayores-menores)<=1;
        }; 


        int i11 = 0;    int i12=nums1.Length-1;
        int i21 = 0;    int i22=nums2.Length-1;


        while(true){
            int posmedian1 = (i11 + i12)/2;
            int posmedian2 = (i21 + i22)/2;

            Console.WriteLine("i11={0}  i12={1}", new object[2]{i11,i12});
            Console.WriteLine("i21={0}  i22={1}", new object[2]{i21,i22});
            Console.WriteLine();
            //Console.ReadLine();

            if(i11>i12) return options[1,0];
            else if(i21>i22) return options[0,0];
            
            if(options[0,0]==(int)Math.Pow(-10,7)){
                options[0,0] = nums1[posmedian1];
                options[0,1] = posmedian1;
                options[0,2] = nums1.Length - posmedian1 - 1;               
            }
            if(options[1,0]==(int)Math.Pow(-10,7)){
                options[1,0]=nums2[posmedian2];
                options[1,1]=posmedian2;
                options[1,2]=nums2.Length - posmedian2 - 1;
            }


            if(options[0,0]<=options[1,0]){
                options[1,1]+=1+options[0,1];
                options[0,2]+=1+options[1,2];
            }
            else{
                options[0,1]+=1+options[1,1];
                options[1,2]+=1+options[0,2];
            }

            bool cond1 = isMedian(options[0,1], options[0,2]);
            bool cond2 = isMedian(options[1,1], options[1,2]);

            if(totalLen%2!=0 && cond1) return options[0,0];
            else if(totalLen%2!=0 && cond2) return options[1,0];
            else if(totalLen%2==0 && cond1 && cond2) return (options[0,0] + options[1,0])/2;

            int dep1 = isDeprecated(options[0,1], options[0,2]);
            int dep2 = isDeprecated(options[1,1], options[1,2]);

            if(dep1==1) i12 = posmedian1-1;
            else if(dep1==2) i11=posmedian1+1;

            if(dep2==1) i22 = posmedian2-1;
            else if(dep2==2) i21=posmedian2+1;

            if(dep1>0){
                if(options[0,0]<=options[1,0]) options[1,1]-=(1+options[0,1]);
                else options[1,2]-=(1+options[0,2]);
                Console.WriteLine("{0} deprecated", options[0,0]);
                options[0,0] = (int)Math.Pow(-10,7);
            }
            else if(dep2>0){
                if(options[1,0]<=options[0,0]) options[0,1]-=(1+options[1,1]);
                else options[0,2] -= (1+options[1,2]);
                Console.WriteLine("{0} deprecated", options[1,0]);
                options[1,0] = (int)Math.Pow(-10,7);
            }
            //else if(totalLen%2==0) return (options[0,0] + options[1,0])/2;
        }
        return Math.Pow(-10, 7);
    }
}