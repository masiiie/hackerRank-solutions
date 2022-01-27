function findMaximumXOR(nums: number[]): number {
    let max = 0;
    console.log(myxor(14,92))
    for (let i = 0; i < nums.length; i++) {
      for (let j = i+1; j < nums.length; j++) {
          let xor = myxor(nums[i], nums[j]);
          max = xor>max ? xor : max;
        }
    }
    return max;
};

function myxor(x:number, y:number){
    return (x|y)-(x&y);
}