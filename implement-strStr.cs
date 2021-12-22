// https://leetcode.com/problems/implement-strstr/


public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length == 0) return 0;
        int index = -1;
        for(int i = 0; i < haystack.Length - needle.Length; i++){
            for(int j = 0; j < needle.Length; j++){
                if(haystack[i+j]!=needle[j]) break;
            }
            if(j==needle.Length){
                index = i;
                break;
            }
        }
        return index;
    }
}