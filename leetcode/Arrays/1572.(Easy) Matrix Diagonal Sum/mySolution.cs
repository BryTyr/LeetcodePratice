/*
Given a square matrix mat, return the sum of the matrix diagonals.

Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

*/
public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0;
        int depthIn = 0;
        bool middleFlag = false;
        
        for(int i=0;i<mat.GetLength(0);i++){
            
            // hit the middle
            if(depthIn == (mat[0].Length - 1 - depthIn)){
                middleFlag = true;
                sum += mat[i][depthIn];
                depthIn--;
                continue;
            }
            
            // add to the sum at each index
            sum += mat[i][depthIn];
            sum += mat[i][(mat[0].Length - 1 - depthIn)];
            
            
            // move y index in or out
            if(middleFlag){
                depthIn--;
            }
            else{
                depthIn++;
            }
        }
        
        return sum;
    }
}