/*
Given an integer array nums, return the greatest common divisor of the smallest number and largest number in nums.

The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
*/

public class Solution {
    public int FindGCD(int[] nums) {
        int smallestNum = 1001; // largest num possible 1000
        int largestNum = 0; // smallest num possible 1
        
        // get largest and smallest num from array
        for(int i=0;i<nums.Length;i++){
            if(nums[i] > largestNum){
                largestNum = nums[i];
            }
            if(nums[i] < smallestNum){
                smallestNum = nums[i];
            }
        }
        
        // find largest num that divides both
        for(int i=smallestNum;i>1;i--){
            if(largestNum%i==0 && smallestNum%i==0){
                return i;
            }
        }
        
        // one always divides
        return 1;
    }
}