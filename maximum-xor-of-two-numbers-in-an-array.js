function findMaximumXORNaive(nums) {
    var max = 0;
    console.log(myxor(14, 92));
    for (var i = 0; i < nums.length; i++) {
        for (var j = i + 1; j < nums.length; j++) {
            var xor = nums[i] ^ nums[j];
            console.log(xor);
            max = xor > max ? xor : max;
        }
    }
    return max;
}
;
function myxor(x, y) {
    return (x | y) - (x & y);
}
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
    while (index < value.length) {
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
        index += 1;
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
        //console.log(`tostringItem = ${tostringItem}`);
        toBinaryDic[tostringItem] = element;
        var added = tree.add(tostringItem);
        //console.log(`added = ${returnValue(added)}`);
        //console.log(`\n\n\n`)
    });
    var maxXor = -1;
    nums.forEach(function (item) {
        var head = tree;
        var current = searchMaxXor(toBinary(item), head);
        //console.log(`toBinary(item) = ${toBinary(item)}`);
        //console.log(`current        = ${current}`);
        //console.log(`current        = ${toBinaryDic[current]}`);
        var xor = toBinaryDic[current] ^ item;
        maxXor = xor > maxXor ? xor : maxXor;
        //console.log(`maxXor         = ${maxXor}`);
        //console.log(`\n`)
    });
    return maxXor;
}
;
var numsList = [[3, 5, 56, 1], [1, 2, 3], [23, 67, 12, 34, 0, 89, 4], [4, 4, 4, 32, 78]];
numsList.forEach(function (nums) {
    var sol1 = findMaximumXOR(nums);
    var sol2 = findMaximumXORNaive(nums);
    console.log("sol1=" + sol1 + "   sol2=" + sol2 + "\n");
});
