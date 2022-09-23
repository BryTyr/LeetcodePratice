class Solution {
    public int[] sortedSquares(int[] nums) {
        int[] result = new int[nums.length];
        int pl = 0, pr = nums.length-1;
        int arrIndex = nums.length-1;
        
        while(pl <= pr){
           if(Math.abs(nums[pl]) >= Math.abs(nums[pr])){
               result[arrIndex] = nums[pl] * nums[pl];
               pl++;
           }
            else{
                result[arrIndex] = nums[pr] * nums[pr];
               pr--;
            }
            arrIndex--;
        }
        return result;
    }
}