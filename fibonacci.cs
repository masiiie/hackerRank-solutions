public class Solution {
    public int Fib(int n) {
        if(n==0) return 0;
        if(n==1) return 1;

        int last1 = 0;
        int last2 = 1;

        for(int i=2;i<=n;i++){
            int newx = last1+last2;
            last1=last2;
            last2=newx;
        }
        return last2;
    }
}