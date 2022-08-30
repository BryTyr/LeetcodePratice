class Solution {
    public double findMaxAverage(int[] nums, int k) {
        double result = -Double.MAX_VALUE;
        int windowEnd = 0;
        int currSum = 0;
        
        // edge case handling
        if(nums.length < k) return result;
        
        
        for(int windowStart=0; windowStart < nums.length; windowStart++){
            
            currSum += nums[windowStart];
            
            // fill window to fixed size of k
            if(windowStart + 1 < k) continue;
            
            
            result = Math.max(result, (double)currSum/(double)k);
            
            // remove the last value from the window so it conforms to fixed size k
            currSum -= nums[windowEnd];
            windowEnd++;
            
        }
        
        return result;
    }
}