public class Solution {
    public int BalancedStringSplit(string s) {
        int balanced = 0;

        int rCount = 0;
        int lCount = 0;
        bool toComplete = false;
        bool r = s[0]=='R';
        for(int i=0;i<s.Length;i++){
            if(s[i]=='R' && r) rCount++;
            else if(s[i]=='L' && !r) lCount++;
            else if(toComplete){
                    balanced++;
                    rCount= s[i]=='R' ? 1 : 0; lCount= s[i]=='R' ? 0 : 1;
                    toComplete = false;
            }
            else toComplete = true;
            r = s[i]=='R';
        }

        return toComplete && rCount*lCount>0 ? balanced+1 : balanced;
    }
}