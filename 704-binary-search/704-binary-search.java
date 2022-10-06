class Solution {
    public int search(int[] arr, int target) {
        int start = 0, end = arr.length - 1;

        while(start <= end){
          int middle = start + (end-start)/2;
          int num = arr[middle];
          if(num == target){
            return middle;
          }
          
          if(target < num){
            end = middle - 1;
          }
          else{
            start = middle + 1;
          }
          
        }

        return -1;
    }
}