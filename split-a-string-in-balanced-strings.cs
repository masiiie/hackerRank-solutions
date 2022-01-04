public class Solution {
    public int BalancedStringSplit(string s) {
        int balanced = 0;

        int rCount = 0;
        int lCount = 0;
    
        for(int i=0;i<s.Length;i++){
            if(s[i]=='R') rCount++;
            else lCount++;

            if(rCount==lCount){
                balanced++;
                toComplete=false;
                rCount=0; lCount=0;
            }
        }

        return balanced;
    }
}