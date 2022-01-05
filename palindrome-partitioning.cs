// https://leetcode.com/problems/palindrome-partitioning/

public class Solution {
    Dictionary<string,bool> pal;
    public IList<IList<string>> Partition(string s) {
        Dictionay<string,IList<IList<string>>> solutions = new Dictionay<string,IList<IList<string>>>();

        for(int i = 0; i<s.Length; i++) solutions[s.Substring(i,i+1)] = (IList<IList<string>>)(new List<IList<string>>(){
            (IList<string>)(new List<string>(){s.Substring(i,i+1)})
        });

        for(int i=1;i<s.Length;i++){
            for(int j=0;j<s.Length;j++){
                string substring = s.Substring(j,j+i+1);
                solution[j,j+i]= new List<IList<string>>(){};


                if(ispalindrome(substring)) solution[j,j+i].Add((IList<string>)(new List<string>(){substring}));
            }
        }
    }

    public Solution(){
        pal = new Dictionary<string, bool>();
    }

    public bool ispalindrome(string s){
        if(pal.Contains(s)) return pal[s];
        bool answer = true;

        for(int i=0; i<s.Length/2; i++){
            if(s[i]!=s[s.Length-1-i]){
                answer=false;
                break;
            }
        }
        pal.Add(s,answer);
        return answer;
    }
}