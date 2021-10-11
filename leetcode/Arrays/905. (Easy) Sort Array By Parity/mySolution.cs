/*
Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.

 

Example 1:

Input: nums = [3,1,2,4]
Output: [2,4,3,1]
Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.


*/
public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int firstHalfIndex = 0;
        int secondHalfIndex = nums.Length-1;
        int[] resultArr = new int[nums.Length];
        
        for(int i=0;i<nums.Length;i++){
            if((nums[i] % 2) == 0){
                resultArr[firstHalfIndex] = nums[i];
                firstHalfIndex++;
            }
            else{
                resultArr[secondHalfIndex] = nums[i];
                secondHalfIndex--;                
            }
        }
        
        return resultArr;
    }
}