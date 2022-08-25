class Solution {
    public int[][] merge(int[][] intervals) {
        
        ArrayList<int[]> result = new ArrayList<>();
        
        if(intervals.length <= 1) return intervals;
        
        
        Arrays.sort(intervals, (a,b) -> Integer.compare(a[0], b[0]));
        
        int[] currInterval = intervals[0];
        
        for(int i=1; i<intervals.length;i++){
            
            // no overlap, add interval and repeat
            if(intervals[i][0] > currInterval[1]){
                result.add(currInterval);
                currInterval = intervals[i];
                continue;
            }
            // merge
            currInterval[0] = Math.min(currInterval[0], intervals[i][0]);
            currInterval[1] = Math.max(currInterval[1], intervals[i][1]);
        }
        
        result.add(currInterval);
        
        return result.toArray(new int[result.size()][]);
        
    }
}