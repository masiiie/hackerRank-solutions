using System;

public class Solution {
    public string ReverseWords(string s) {
        Func<int,int,string> reverse = (int i, int j) =>{
            string auxiliar = (j-i)%2==0 ? s[(j-i)/2].ToString() : "";
            for(int k=((j-i)/2)-1;k>=i;k++) auxiliar = s[j-k] + auxiliar + s[k];
            return auxiliar;
        };

        int i=0;
        int j=0;
        while(s[j]!=' ') j++;
        string sol= reverse(i,j-1);
        i=j+1; j++;


        while(j<s.Length){
            while(s[j]!=' ') j++;
            sol += " "+reverse(i,j-1);
            i=j+1; j++;
        }

        return sol;
    }
}