/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function(nums1, m, nums2, n) {
    let i=m-1;
    let j=n-1;
    let temp=nums1.length-1; 
     while(j>=0){
        if(i>=0 && nums1[i]>nums2[j]){
            nums1[temp]=nums1[i];
            temp--; 
            i--;
         }else{
            nums1[temp] = nums2[j];
            temp--; 
            j--; 
        }     
    }
};


// esta solucion no la hice yo, la mia estaba en candela