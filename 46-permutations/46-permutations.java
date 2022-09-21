class Solution {
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        Queue<List<Integer>> permutations = new LinkedList<>();
        permutations.add(new ArrayList<>());
        
        for(int num : nums){
            int permsSize = permutations.size();
            for(int i=0; i<permsSize; i++){
                List<Integer> oldPerm = permutations.poll(); 
                for(int j=0; j<=oldPerm.size(); j++){
                    List<Integer> newPerm = new ArrayList<>(oldPerm);
                    newPerm.add(j, num);
                    permutations.add(newPerm);
                }   
            }
        }
        for(List<Integer> perm : permutations){
            result.add(perm);
        }
        return result;
    }
}