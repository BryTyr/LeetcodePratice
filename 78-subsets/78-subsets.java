class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> subsets = new ArrayList<List<Integer>>();
        
        // add an empty first set
        subsets.add(new ArrayList<>());
        
        for(int num : nums){
            int subsetsSize = subsets.size();
            for(int i=0;i<subsetsSize;i++){
                ArrayList<Integer> subset = new ArrayList<>(subsets.get(i));
                subset.add(num);
                subsets.add(subset);
            }
        }
        return subsets;
    }
}