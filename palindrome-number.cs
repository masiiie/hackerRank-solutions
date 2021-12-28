public class Solution {
    public bool IsPalindrome(int x) {
        string ToString = x.ToString();
        return IsPalindrome(ToString);
    }

    bool IsPalindrome(string x){
        if(x.Length == 1) return true;
        if(x.Length == 0) return true;
        if(x[0] != x[x.Length - 1]) return false;
        return IsPalindrome(x.Substring(1, x.Length-2));
    }
}