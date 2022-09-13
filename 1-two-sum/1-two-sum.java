class Solution {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer,Integer> remainderMap = new HashMap<>();
        
        for(int i=0;i<nums.length; i++){
            
            int remainder = target - nums[i];
            
            if(remainderMap.containsKey(remainder)){
                return new int[]{remainderMap.get(remainder), i};
            }
            
            remainderMap.put(nums[i], i);
        }
        
        // should technically throw an error here as the solution states there must be one correct answer
        // since its leetcode an empty return is easier
        return new int[]{0,0};
    }
}