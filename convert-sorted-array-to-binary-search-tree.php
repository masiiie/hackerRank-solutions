/**
 * https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/submissions/
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
     * @param Integer[] $nums
     * @return TreeNode
     */
    function sortedArrayToBST($nums) {
        $N = count($nums);
        if($N == 0) return null;
        if($N == 1) return new TreeNode($nums[0], null, null);
        $middle = $N/2;
        $sp1 = array_slice($nums,0, $middle);
        $sp2 = array_slice($nums, $middle + 1, $N);
        $left = $this->sortedArrayToBST($sp1);
        $right = $this->sortedArrayToBST($sp2);
        $solution = new TreeNode($nums[$middle], $left, $right);
        return $solution;
    }
}