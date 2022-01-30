/*
    function findMaximumXOR(nums: number[]): number {
    let max = 0;
    for (let i = 0; i < nums.length; i++) {
      for (let j = i+1; j < nums.length; j++) {
          let xor = nums[i] ^ nums[j];
          max = xor>max ? xor : max;
        }
    }
    return max;
};
*/

class BST{
    left : BST;
    right : BST;
    parent : BST;
    value : string;

    constructor(value? : string, parent? : BST){
        this.value = value ? value : null;
        this.parent = parent ? parent : null;
        this.left = null;
        this.right = null;
    }

    add(item:string){
        this.addAux(item, 0, this);
    }

    addAux(item:string, index:number, head:BST){
        if(index<item.length){
            if(item[index]=='0'){
                if(head.left == null) head.left = new BST('0', head);
                this.addAux(item, index+1, head.left);
            }   
            else{
                if(head.right == null) head.right = new BST('1', head);
                this.addAux(item, index + 1, head.right);
            }   
        } 
    }

}

function toBinary(dec) {
    let sol = (dec >>> 0).toString(2);
    return miRepeat('0', 32-sol.length) + sol;
}

function miRepeat(word : string, times : number) : string{
    let solution = '';
    while(times > 0){
        times--;
        solution += word;
    }
    return solution;
}

function searchMaxXor(value : string, tree : BST) : string{
    let index = 0;
    let maxXor = '';
    while(index < value.length){
        if(value[index]=='0'){
            if(tree.right!=null){
                maxXor+= '1';
                tree = tree.right;
            }
            else{
                maxXor+='0';
                tree = tree.left;
            }
        }
        else{
            if(tree.left!=null){
                maxXor+='0';
                tree = tree.left;
            }
            else{
                maxXor+='1';
                tree = tree.right;
            }
        }
        index+=1;
    }

    return maxXor;
}

function returnValue(tree:BST){
    let solution = "";
    while(tree.parent!=null){
        solution = tree.value + solution;
        tree = tree.parent;
    }
    return solution;
}

function findMaximumXOR(nums: number[]): number {
    let tree = new BST('-1', null);
    let toBinaryDic: { [id:string]: number; } = {};
    nums.forEach(element => {
        let tostringItem = toBinary(element);
        toBinaryDic[tostringItem] = element;
        tree.add(tostringItem);
    });
    let maxXor = -1;
    nums.forEach(item => {
        let head = tree;
        let current = searchMaxXor(toBinary(item), head);
        let xor = toBinaryDic[current] ^ item;
        maxXor = xor>maxXor ? xor : maxXor;
    });
    return maxXor;
};