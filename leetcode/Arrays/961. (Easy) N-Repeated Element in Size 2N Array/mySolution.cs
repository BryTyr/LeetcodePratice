/*
ou are given an integer array nums with the following properties:

nums.length == 2 * n.
nums contains n + 1 unique elements.
Exactly one element of nums is repeated n times.
Return the element that is repeated n times.

 

Example 1:

Input: nums = [1,2,3,3]
Output: 3

*/
public class Solution {
    public int RepeatedNTimes(int[] nums) {
        Dictionary<int,int> uniqueVals = new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
            if(uniqueVals.ContainsKey(nums[i])){
                return nums[i];
            }else{
                uniqueVals[nums[i]] = nums[i];
            }
        }
        
        return 0;
    }
}