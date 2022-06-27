class Solution {

/**
 * https://leetcode.com/problems/majority-element/submissions/
 * Boyer-Moore Voting Algorithm
 * @param Integer[] $nums
 * @return Integer
 */
function majorityElement($nums) {
    $element = $nums[0];
    $rep = 1;
    for($i = 1; $i < count($nums); $i++){
        if($nums[$i] == $element) $rep++;
        else{
            $rep--;
            if($rep == 0){
                $element = $nums[$i];
                $rep = 1;
            }
        }
    }
    
    return $element;
}
}