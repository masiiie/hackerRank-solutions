/**
 * https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
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
     * @param Integer[] $inorder
     * @param Integer[] $postorder
     * @return TreeNode
     */
    function buildTree($inorder, $postorder) {
        $N = count($inorder);
        $value = end($postorder);
        if($N == 0) return null;
        if($N == 1) return new TreeNode($value, null, null);
        
        
        $countLeft = 0;
        for($i=0; $i<$N;$i++){
            if($inorder[$i]!=$value) $countLeft++;
            else break;
        }
        
        $left1 = array_slice($inorder, 0, $countLeft);
        $right1 = array_slice($inorder, $countLeft, $N);
        
        $left2 = array_slice($postorder, 0, $countLeft);
        $right2 = array_slice($postorder, $countLeft, $N - $countLeft - 1);
        
        $left = $this->buildTree($left1, $left2);
        $right = $this->buildTree($right2, $right2);
        return new TreeNode($value, $left, $right);
    }
}