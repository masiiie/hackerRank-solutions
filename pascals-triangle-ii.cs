// https://leetcode.com/problems/pascals-triangle-ii/

public class Solution {
    List<IList<int>> solution;
    public IList<int> GetRow(int rowIndex) {
        if(rowIndex < solution.Count) return solution[rowIndex];

        while(solution.Count<=rowIndex){
            int i = solution.Count;
            int[] newx = new int[i+1];
            newx[0]=1; newx[i]=1;
            for(int j=0;j<solution[i-1].Count/2;j++){
                newx[j+1]=solution[i-1][j]+solution[i-1][j+1];
                newx[newx.Length-j-2]=newx[j+1];
            }
            solution.Add((IList<int>)(new List<int>(newx)));
        }
        return solution[rowIndex];
    }

    public Solution(){
        solution = new List<IList<int>>(){
            (IList<int>)(new List<int>(){1}),
            (IList<int>)(new List<int>(){1,1}),
            (IList<int>)(new List<int>(){1,2,1})
        };
    }
}