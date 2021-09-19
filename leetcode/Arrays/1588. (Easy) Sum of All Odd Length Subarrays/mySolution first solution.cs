public class Solution {
    /*
	(not proud of this one. Will give it another go with a more efficient approach)
	
    Given an array of positive integers arr, calculate the sum of all possible odd-length subarrays.

    A subarray is a contiguous subsequence of the array.

    Return the sum of all odd-length subarrays of arr.
        
    */
    public int SumOddLengthSubarrays(int[] arr) {
        int arrSize = 1;
        int oddArrSum = 0;
        
        while(arrSize<=arr.Length){
            
            for(int i=0;i<arr.Length && i+arrSize<=arr.Length;i++){
                int sum = 0;
                int count=0;
                for(int j=i;count<arrSize;j++){
                    sum+=arr[j];
                    count+=1;
                    
                }
                oddArrSum+=sum;
            }
            arrSize+=2;
        }
        return oddArrSum;
    }
}