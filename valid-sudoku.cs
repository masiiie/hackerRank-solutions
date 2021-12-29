// https://leetcode.com/problems/valid-sudoku/

// Congrats!!

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9,9];
        bool[,] cols = new bool[9,9];
        bool[,] subBox = new bool[9,9];

        for(int i=0; i<9; i++){
            for(int j=0; j<9; j++){
                int value;
                bool converted = int.TryParse((board[i][j]).ToString(), out value);
                if(!converted) continue;
                if(rows[i,value-1]) return false;
                else rows[i,value-1] = true;
                if(cols[j,value-1]) return false;
                else cols[j,value-1]= true;

                int box = -1;
                

                if(0<=i && i<=2 && 0<=j && j<=2) box=0;
                else if(0<=i && i<=2 && 3<=j && j<=5) box=1;
                else if(0<=i && i<=2 && 6<=j && j<=8) box=2;
                else if(3<=i && i<=5 && 0<=j && j<=2) box=3;
                else if(3<=i && i<=5 && 3<=j && j<=5) box=4;
                else if(3<=i && i<=5 && 6<=j && j<=8) box=5;
                else if(6<=i && i<=8 && 0<=j && j<=2) box=6;
                else if(6<=i && i<=8 && 3<=j && j<=5) box=7;
                else if(6<=i && i<=8 && 6<=j && j<=8) box=8;

                if(subBox[box,value-1]) return false;
                else subBox[box,value-1]=true;
            }
        }
        return true;
    }
}