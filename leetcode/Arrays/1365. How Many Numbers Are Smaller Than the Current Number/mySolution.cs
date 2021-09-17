public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        
        SortedDictionary<int,List<int>> intIndexes = new SortedDictionary<int,List<int>>();
        int[] ans = new int[nums.Length];
        
        for(int i=0;i<nums.Length;i++){
            if(intIndexes.ContainsKey(nums[i])){
                intIndexes[nums[i]].Add(i);
            }
            else{
                intIndexes[nums[i]] = new List<int>(){i};
            }
        }
        
        int runningCount = 0;
        foreach(KeyValuePair<int,List<int>> entry in intIndexes)
        {
            if(entry.Key==0){
                runningCount += entry.Value.Count;
                continue;
            }
            
            int smallerCount = runningCount;
            foreach(int index in entry.Value){
                ans[index] = smallerCount;
                runningCount++;
                
            }
        }
        
        return ans;
    }
}