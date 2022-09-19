class Solution {
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        List<List<Integer>> subsets = new ArrayList<>();
        
        Arrays.sort(nums);
        subsets.add(new ArrayList<>());
        
        int prevSubsetSize = 0;  
        for(int i=0;i<nums.length;i++){
          int subsetStart = 0;
          int subSetSize = subsets.size();
          
            if(i > 0 && nums[i] == nums[i-1]){
            subsetStart = prevSubsetSize;
          }
          prevSubsetSize = subsets.size();
          
            for(int j=subsetStart;j<subSetSize;j++){
              ArrayList<Integer> newSubset = new ArrayList<>(subsets.get(j));
              newSubset.add(nums[i]);
              subsets.add(newSubset);
          }
        }

        return subsets;
    }
}