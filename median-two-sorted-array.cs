using System;
using System.Collections.Generic;

public class Program
{
    public static List<Tuple<int[],int[],double>> answers = new List<Tuple<int[], int[], double>>(){
        new Tuple<int[], int[], double>(
            new int[2]{0,100},
            new int[10]{1,2,3,4,5,6,7,8,9,10}, 
            5.5),
        new Tuple<int[], int[], double>(
            new int[2]{1,5}, 
            new int[4]{2,3,4,6}, 
            3.5),
        new Tuple<int[], int[], double>(
            new int[1]{1}, 
            new int[3]{2,3,4}, 
            2.5),
        new Tuple<int[], int[], double>(
            new int[4]{7,10,21,44}, 
            new int[4]{22,30,31,40}, 
            26),
        new Tuple<int[], int[], double>(
            new int[4]{1,2,3,4}, 
            new int[8]{1,2,3,4,5,6,7,8}, 
            3.5),
        new Tuple<int[], int[], double>(
            new int[4]{1,2,3,4}, 
            new int[10]{1,2,3,4,5,6,7,8,8,8}, 
            4),
        new Tuple<int[], int[], double>(
            new int[4]{1,3,5,7}, 
            new int[4]{2,3,6,8}, 
            4),
        new Tuple<int[], int[], double>(
            new int[4]{1,1,2,3}, 
            new int[5]{1,2,2,6,7}, 
            2),
        new Tuple<int[], int[], double>(
            new int[7]{7,10,21,44,45,46,47}, 
            new int[7]{22,30,31,40,40,40,40}, 
            40),
        new Tuple<int[], int[], double>(
            new int[4]{7,8,8,9}, 
            new int[20]{1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9}, 
            8),
        new Tuple<int[], int[], double>(
            new int[4]{1,2,3,3}, 
            new int[20]{1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9}, 
            8),
        new Tuple<int[], int[], double>(
            new int[3]{8,8,9}, 
            new int[2]{8,9}, 
            8),
        new Tuple<int[], int[], double>(
            new int[10]{1,1,1,1,1,1,1,1,1,1}, 
            new int[10]{1,1,1,1,1,1,1,1,1,1}, 
            1),
        new Tuple<int[], int[], double>(
            new int[8]{7,8,8,8,8,8,8,9}, 
            new int[26]{1,1,1,1,1,1,1,2,3,3,3,6,7,8,8,8,9,9,9,9,9,9,9,9,9,9}, 
            8),
        new Tuple<int[], int[], double>(
            new int[4]{1,3,5,7}, 
            new int[5]{2,4,6,8,10}, 
            5),
        new Tuple<int[], int[], double>(
            new int[1]{2}, 
            new int[2]{1,3}, 
            2),
        new Tuple<int[], int[], double>(
            new int[3]{1,2,3}, 
            new int[4]{4,5,6,7}, 
            4)
    };

    public static string printArray<T>(T[] array){
        string sol = "{ ";
        foreach(T item in array) sol+=item.ToString()+" ";
        return sol+"}";
    }
	public static void Main()
	{
		Solution sol = new Solution();
        int[] nums1 = new int[4]{1,2,3,4};
        int[] nums2 = new int[8]{1,2,3,4,5,6,7,8};


        foreach(Tuple<int[],int[],double> case_ in answers){
            nums1 = case_.Item1; nums2 = case_.Item2; 
            double realSolution = case_.Item3;
            double calculated = sol.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine("nums1={0}    nums2={1}", printArray(nums1), printArray(nums2));
            Console.WriteLine("real={0}   calculated={1}", realSolution, calculated);
            Console.ReadLine();
            if(calculated!=realSolution) break;
            else{
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        Console.WriteLine("All passed!!");
	}
}

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[,] options = new int[2,3];
        int totalLen = nums1.Length + nums2.Length;
        int umbral = totalLen%2!=0 ? (totalLen-1)/2 : totalLen/2;
        

        Func<int,int,int,int> findFirstLimit =
            (int actualValue, int posmedian, int mayores) =>
            Math.Max(actualValue, posmedian - Math.Max(-1, umbral - mayores));

        Func<int,int,int,int> findSecondLimit = 
            (int actualValue, int posmedian, int menores) =>
             Math.Min(actualValue, posmedian + Math.Max(-1, umbral - menores));

        Func<int,int,bool> isMedian = (int menores, int mayores) => {
            return (menores+mayores+1)==totalLen && mayores==menores;
        }; 

        Func<int[,], bool> areMedianToguether = (int[,] actualOptions) => {
            int m1 = actualOptions[0,0]; int m2 = actualOptions[1,0];
            int men1 = actualOptions[0,1]; 
            int may1 = actualOptions[0,2]; 

            return m1==m2 && men1==may1;
        };

        int i11=0;    int i12=nums1.Length-1;
        int i21=0;    int i22=nums2.Length-1;

        bool change1=true; bool change2=true;


        while(true){
            int posmedian1 = (i11 + i12)/2;
            int posmedian2 = (i21 + i22)/2;

            
            Console.WriteLine("i11={0}  i12={1}", i11, i12);
            Console.WriteLine("i21={0}  i22={1}", i21, i22);
            Console.WriteLine();
            //Console.ReadLine();
            

            if(i11==i12 && i21==i22 && totalLen%2==0) return (double)(nums1[i11]+nums2[i22])/(double)2;
            else if(i11>i12){
                if(totalLen%2==0) 
                    return (i22-i21)%2!=0 ?
                    (double)(nums2[posmedian2]+nums2[posmedian2+1])/(double)2 :
                    (double)(nums2[posmedian2]+nums2[posmedian2-1])/(double)2;
                else return nums2[posmedian2];
            }
            else if(i21>i22){
                if(totalLen%2==0) 
                    return (i12-i11)%2!=0 ?
                    (double)(nums1[posmedian1]+nums1[posmedian1+1])/(double)2 :
                    (double)(nums1[posmedian1]+nums1[posmedian1-1])/(double)2;
                else return nums1[posmedian1];
            }
            else if(!change1 && !change2 && (i12-i11)+(i22-i21)== 1){
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


            int last1 = i11; int last2 = i12;
            i11= findFirstLimit(i11, posmedian1, options[0,2]);
            i12= findSecondLimit(i12, posmedian1, options[0,1]);
            change1 = last1!=i11 || last2!=i12;

            last1 = i21; last2 = i22;
            i21= findFirstLimit(i21, posmedian2, options[1,2]);
            i22= findSecondLimit(i22, posmedian2, options[1,1]);
            change2 = last1!=i21 || last2!=i22;

            if(!change1 && !change2 && options[0,0]==options[1,0] && !cond3){
                change1 = true;
                i11+=1;
            }
        }
        return Math.Pow(-10, 7);
    }
}

/*
    int dep3 = options[0,0]==options[1,0] && dep1==0 && 
        ((totalLen%2==0 && !cond3) || totalLen%2!=0) ? 1 : 0;
*/