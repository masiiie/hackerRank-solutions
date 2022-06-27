class Solution {

/**
 * @param Integer[] $nums
 * @return Integer
 
 Kadane's Algorithm implementation
 https://leetcode.com/problems/maximum-subarray
 */
function maxSubArray($nums) {
    $general = pow(-10, 5);
    $current = pow(-10, 5);
    echo $general;
    for($i = 0; $i < count($nums); $i++){
        $current = max($nums[$i], $current + $nums[$i]);
        $general = max($general, $current);
    }
    return $general;
}
}