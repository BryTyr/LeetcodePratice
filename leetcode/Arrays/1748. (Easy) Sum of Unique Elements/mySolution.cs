/*
You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.

Return the sum of all the unique elements of nums.

 

Example 1:

Input: nums = [1,2,3,2]
Output: 4
Explanation: The unique elements are [1,3], and the sum is 4.

*/

public class Solution {
    public int SumOfUnique(int[] nums) {
        Dictionary<int,bool> uniqueVals = new Dictionary<int,bool>();
        int uniqueSum = 0;
        
        for(int i=0;i<nums.Length;i++){
            if(uniqueVals.ContainsKey(nums[i]) && uniqueVals[nums[i]] == true){
                uniqueSum -= nums[i];
                uniqueVals[nums[i]] = false;
            }
            
            else if(uniqueVals.ContainsKey(nums[i]) && uniqueVals[nums[i]] == false){
                continue;
            }
            else{
                uniqueSum += nums[i];
                uniqueVals[nums[i]] = true;
            }
        }
        return uniqueSum;
    }
}