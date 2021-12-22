// https://leetcode.com/problems/roman-to-integer/

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> values = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };

        int sol = 0;

        for(int i=0; i<s.Length; i++){
            if((i+1)<s.Length && values[s[i]]<values[s[i+1]]){
                sol+= (values[s[i+1]] - values[s[i]]);
                i+=1;
            }
            else{
                sol+= values[s[i]];
            }
        }
        return sol;
    }
}