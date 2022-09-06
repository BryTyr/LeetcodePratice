class Solution {
    public int threeSumClosest(int[] nums, int target) {
        int closestSum = nums[0] + nums[1] + nums[2];
        int difference = Integer.MIN_VALUE;
        int j=0;
        int k = nums.length-1;
        
        Arrays.sort(nums);
        
        for(int i=0;i<nums.length-2;i++){
            j = i+1;
            k = nums.length-1;
            
            while(j<k){
                int currSum = nums[i] + nums[j] + nums[k];
                
                if (currSum > target) {
                    k--;
                } else {
                    j++;
                }
                if (Math.abs(currSum - target) < Math.abs(closestSum - target)) {
                    closestSum = currSum;
                }
            }
        }
        return closestSum;
    }
}