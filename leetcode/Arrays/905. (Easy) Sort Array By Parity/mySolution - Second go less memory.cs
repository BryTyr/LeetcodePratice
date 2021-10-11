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
        int secondHalfIndex = nums.Length-1;
        int currentIndex = 0;
        
        while(currentIndex <= secondHalfIndex){
            
            if((nums[currentIndex] % 2) == 0){
                currentIndex++;
                continue;
            }
            else{
                int temp = nums[currentIndex];
                nums[currentIndex] = nums[secondHalfIndex];
                nums[secondHalfIndex] = temp;
                secondHalfIndex--;
            }
        }
        
        return nums;
    }
}