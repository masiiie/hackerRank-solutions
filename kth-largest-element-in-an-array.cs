public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int sol = 0;
        SortedList<int, int> openWith = new SortedList<int, int>();
        Dictionary<int, int> quantities = new Dictionary<int, int>();
        foreach (var item in nums){
            int key = item*(-1);
            int index = openWith.IndexOfKey(key);
            if(index > -1)quantities[key]++;
            else{
                quantities.Add(key, 1);
                openWith.Add(key, item);
            }
        }  
        while (true){
            var first = openWith.First();
            if(k > quantities[first.Key]){
                openWith.RemoveAt(0);
                k = k - quantities[first.Key];
            }
            else break;
        }
        return openWith.First().Value;
    }
}