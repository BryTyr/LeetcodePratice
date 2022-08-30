class Solution {
    public int[] runningSum(int[] nums) {
        
        if(nums.length == 0) return new int[0];
        
        int[] runningSumArr = new int[nums.length];
        runningSumArr[0] = nums[0];
        int prevSum = runningSumArr[0];
        
        for(int i=1; i < nums.length; i++){
            runningSumArr[i] = nums[i] + prevSum;
            prevSum = runningSumArr[i];
        }
        
        return runningSumArr;
    }
}