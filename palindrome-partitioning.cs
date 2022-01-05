// https://leetcode.com/problems/palindrome-partitioning/
using System;
public class Solution {
    Dictionary<string,bool> pal;

    public IList<IList<string>> Partition(string s) {
        Dictionary<string,IList<IList<string>>> solution = new Dictionary<string,IList<IList<string>>>();
        solution[""] = (IList<IList<string>>)(new List<IList<string>>(){
            (IList<string>)(new List<string>(){})
        });

        for(int i=1;i<=s.Length;i++){
            //Console.WriteLine("i={0}",i);
            for(int j=0;j<s.Length && (i+j)<=s.Length;j++){
                //Console.WriteLine(" j={0}",j);
                string substring = s.Substring(j,i);
                solution[substring]= new List<IList<string>>(){};

                for(int k=1; k<substring.Length;k++){
                    //Console.WriteLine("     k={0}",k);
                    string newp = substring.Substring(0,k);
                    if(ispalindrome(newp)){
                        foreach(IList<string> way in solution[substring.Substring(k, substring.Length-k)]){
                            List<string> toAdd = new List<string>(){newp};
                            toAdd.AddRange(way);
                            solution[substring].Add((IList<string>)toAdd);
                        }
                    }
                }

                if(ispalindrome(substring)) solution[substring].Add((IList<string>)(new List<string>(){substring}));
                solution[substring] = (IList<IList<string>>)solution[substring];
            }
        }

        return solution[s];
    }

    public Solution(){
        pal = new Dictionary<string, bool>();
    }

    public bool ispalindrome(string s){
        if(pal.ContainsKey(s)) return pal[s];
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