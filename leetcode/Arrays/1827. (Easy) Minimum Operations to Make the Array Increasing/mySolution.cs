/*
An array nums is strictly increasing if nums[i] < nums[i+1] for all 0 <= i < nums.length - 1. An array of length 1 is trivially strictly increasing.

 

Example 1:

Input: nums = [1,1,1]
Output: 3
Explanation: You can do the following operations:
1) Increment nums[2], so nums becomes [1,1,2].
2) Increment nums[1], so nums becomes [1,2,2].
3) Increment nums[2], so nums becomes [1,2,3].


*/

public class Solution {
    public int MinOperations(int[] nums) {
        int opertions = 0;
        
        if(nums.Length<=1)
            return 0;
       
        for(int i=0;i<nums.Length-1;i++){
          
            // find difference between current and next array value
            int diff = nums[i]-nums[i+1];
            
            if(diff>=1){
                opertions+=diff + 1; // add the difference plus 1 to make it larger
                nums[i+1]+=diff + 1;
            }
            else if(diff==0){
                opertions += 1; // if the same value onyl 1 needed
                nums[i+1] += 1;
            }
            else{
                continue; // if value is smaller continue
            }
        }
        
        
        return opertions;
    }
}