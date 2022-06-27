/**
 * https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
 * Definition for a binary tree node.
 * class TreeNode {
 *     public $val = null;
 *     public $left = null;
 *     public $right = null;
 *     function __construct($val = 0, $left = null, $right = null) {
 *         $this->val = $val;
 *         $this->left = $left;
 *         $this->right = $right;
 *     }
 * }
 */
class Solution {

    /**
     * @param Integer[] $preorder
     * @param Integer[] $inorder
     * @return TreeNode
     */
    function buildTree($preorder, $inorder) {
        echo "preorder:";
        print_r($preorder);
        echo "inorder:";
        print_r($inorder);
        echo "";
        
        $N = count($preorder);
        $value = $preorder[0];
        if($N == 0) return null;
        if($N == 1) return new TreeNode($value, null, null);
        
        $leftCount = 0;
        for($i = 0; $i < count($inorder); $i++){
            if($inorder[$i] != $value) $leftCount++;
            else break;
        }
        
        $left1= array_slice($preorder, 1, $leftCount);
        $rigth1= array_slice($preorder, $leftCount + 1, $N);
        
        $left2 = array_slice($inorder, 0, $leftCount);
        $rigth2 = array_slice($inorder, $leftCount + 1, $N);
        
        $left = $this->buildTree($left1, $left2);
        $rigth = $this->buildTree($rigth1, $rigth2);
        return new TreeNode($value, $left, $rigth); 
    }
}