/*

function findMaximumXOR(nums: number[]): number {
    let max = 0;
    console.log(myxor(14,92))
    for (let i = 0; i < nums.length; i++) {
      for (let j = i+1; j < nums.length; j++) {
          let xor = nums[i] ^ nums[j];
          console.log(xor);
          max = xor>max ? xor : max;
        }
    }
    return max;
};


*/
var BST = /** @class */ (function () {
    function BST(value, parent) {
        this.value = value ? value : null;
        this.parent = parent ? parent : null;
        this.left = null;
        this.right = null;
    }
    BST.prototype.add = function (item) {
        return this.addAux(item, 0, this);
    };
    BST.prototype.addAux = function (item, index, head) {
        if (index < item.length) {
            if (item[index] == '0') {
                if (head.left == null)
                    head.left = new BST('0', head);
                return this.addAux(item, index + 1, head.left);
            }
            else {
                if (head.right == null)
                    head.right = new BST('1', head);
                return this.addAux(item, index + 1, head.right);
            }
        }
        else
            return head;
    };
    return BST;
}());
function toBinary(dec) {
    var sol = (dec >>> 0).toString(2);
    return miRepeat('0', 32 - sol.length) + sol;
}
function miRepeat(word, times) {
    var solution = '';
    while (times > 0) {
        times--;
        solution += word;
    }
    return solution;
}
function searchMaxXor(value, tree) {
    var index = 0;
    var maxXor = '';
    while (index < value.length && tree != null) {
        if (value[index] == '0') {
            if (tree.right != null) {
                maxXor += '1';
                tree = tree.right;
            }
            else {
                maxXor += '0';
                tree = tree.left;
            }
        }
        else {
            if (tree.left != null) {
                maxXor += '0';
                tree = tree.left;
            }
            else {
                maxXor += '1';
                tree = tree.right;
            }
        }
    }
    return maxXor;
}
function returnValue(tree) {
    var solution = "";
    while (tree.parent != null) {
        solution = tree.value + solution;
        tree = tree.parent;
    }
    return solution;
}
function findMaximumXOR(nums) {
    var tree = new BST('-1', null);
    var toBinaryDic = {};
    nums.forEach(function (element) {
        var tostringItem = toBinary(element);
        console.log("tostringItem = " + tostringItem);
        toBinary[tostringItem] = element;
        var added = tree.add(tostringItem);
        console.log("added = " + returnValue(added));
        console.log("\n\n\n");
    });
    var maxXor = -1;
    nums.forEach(function (item) {
        var head = tree;
        var current = searchMaxXor(toBinary(item), head);
        console.log("current = " + current);
        var xor = toBinaryDic[current] ^ item;
        maxXor = xor > maxXor ? xor : maxXor;
        console.log("maxXor = " + maxXor);
        console.log("\n");
    });
    return maxXor;
}
;
findMaximumXOR([3, 5, 56, 1]);
