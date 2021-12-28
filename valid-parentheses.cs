public class Solution {
    public bool IsValid(string s) {
        int t1 = 0;
        int t2 = 0;
        int t3 = 0;

        for(int i=0; i<s.Length; i++){
            switch(s[i]) 
            {
                case '(':
                    t1+=1;
                    break;
                case ')':
                    t1-=1;
                    break;
                case '{':
                    t2+=1;
                    break;
                case '}':
                    t2-=1;
                    break;
                case '[':
                    t3+=1;
                    break;
                default:
                    t3-=1;
                    break;
            }
        }

        return t1==0 && t2==0 && t3 == 0;
    }
}