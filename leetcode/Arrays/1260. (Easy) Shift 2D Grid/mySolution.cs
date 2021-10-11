/*
Given a 2D grid of size m x n and an integer k. You need to shift the grid k times.

In one shift operation:

Element at grid[i][j] moves to grid[i][j + 1].
Element at grid[i][n - 1] moves to grid[i + 1][0].
Element at grid[m - 1][n - 1] moves to grid[0][0].
Return the 2D grid after applying shift operation k times.

 

Example 1:


Input: grid = [[1,2,3],[4,5,6],[7,8,9]], k = 1
Output: [[9,1,2],[3,4,5],[6,7,8]]

*/

public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        // gets number of shifts after full loops taken out
        // i.e. a number moves the whole way through the matrix back to the start
        int matrixSize = grid.Length * grid[0].Length;
        int shifts = k % matrixSize;
        
        // initialize output data structure
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());
        
        
        int i=0;
        int j=0;
        int currRow = 0;
        int RowFull = 0;
        
        int loopsToStartIndex = matrixSize - shifts;
        int totalLoopsLeft = matrixSize + (matrixSize - shifts);
        
        while(totalLoopsLeft > 0)
        {
            totalLoopsLeft--;
            
            if(loopsToStartIndex <= 0){
                // if row full move onto the next row
                if(RowFull == grid[0].Length){
                   currRow++;
                    result.Add(new List<int>());
                   RowFull = 0; 
                }

                // add the data to the result array
                result[currRow].Add(grid[i][j]);
                RowFull++;
            }
            
            loopsToStartIndex--;
            
            // check to see if at the end of matrix, then reset to start index
            if(i == (grid.Length - 1) && j == (grid[0].Length - 1)){
                i=0;
                j=0;
                continue;
            }
            // check to see if at the end of a row but more columns left
            if(j == (grid[0].Length-1)){
                i++;
                j=0;
                continue;
            }
        
            j++;
            continue;
            
        }
        
        return result;
    }
}