public class Solution {
    public string AddBinary(string a, string b) {
        string carry = "0"; string sol="";
        for(int i=0; i<Math.Min(a.Length,b.Length);i++){
            int c1;
            string s = sum(a[a.Length-1-i],b[b.Length-1-i],out c1);
            s = sum()
        }
    }

    public string sum(char a, char b, string carryIn, out string carryOut){
        carry="0";
        if(a=='0' && b=='0') return "0";
        else if(a=='0' && b=='1' || a=='1' && b=='0') return "1";
        else{
            carry="1";
            return "0";
        }
    }
}