class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        SortedList<int, int> interval = new SortedList<int, int>();
        Dictionary<int, int> quantities = new Dictionary<int, int>();
        int start = 0;
        int maxLen = 1;
        int currLen = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            int key = nums[i];
            int index = interval.IndexOfKey(key);
            if(index > -1) quantities[key]++;
            else{
                quantities.Add(key, 1);
                interval.Add(key, key);
            }

            int min = interval.First().Value;
            int max = interval.Last().Value;

            if(Math.Abs(max - min) <= limit){
                currLen++;
                maxLen = Math.Max(maxLen, currLen);
            }
            else if(nums[start]==min && quantities[min]==1){
                quantities[min]--;
                start++;
                interval.RemoveAt(0);
            }
            else if(nums[start]==max && quantities[max]==1){
                quantities[max]--;
                start++;
                interval.RemoveAt(interval.Count()-1);
            }
            else{
                max = nums[i];
                min = nums[i];
                currLen = 1;
                start = i;
            }
        }

        return maxLen;
    }
}