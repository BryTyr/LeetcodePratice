class Solution {
    public int pivotIndex(int[] nums) {
        
        // needed help from the solution to solve this one. I used 2 counters on each side and tried
        // to find the balance point but doesnt work with negative numbers
        
        //Remember for next time: totalSum - nums[i] - leftSum == leftSum is a pivot point. totalSum - currLeftSide = leftSide then               //balanced
        
        int totalSum = 0, leftSum = 0;
        for(int num : nums) totalSum += num;
        
        for(int i=0; i < nums.length; i++){
            
            if(totalSum - nums[i] - leftSum == leftSum) return i;
            
            leftSum += nums[i];
        }
        
        return -1;
    }
}