// https://leetcode.com/problems/plus-one/

function plusOne(digits: number[]): number[] {
    let i = digits.length-1;
    let carry = 0;
    while(i>-1){
        if(i==digits.length-1) digits[i]+=1;
        digits[i]+= carry;
        if(digits[i]>9)
        {
            digits[i]=0;
            carry=1;
            i--;
        }
        else{
            carry = 0;
            break;
        }
    }
    if(carry==1) digits = [1].concat(digits);
    return digits;
};



let digit = [1,2,3,5,9,9,9,9];
let newDigit = plusOne(digit); 
console.log(newDigit);