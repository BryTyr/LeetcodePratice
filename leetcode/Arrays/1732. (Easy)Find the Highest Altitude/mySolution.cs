/*
There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.
*/

public class Solution {
    public int LargestAltitude(int[] gain) {
        int highestPoint = 0;
        
        if(gain[0] > highestPoint){
            highestPoint = gain[0];
        }
        
        for(int i=1;i<gain.Length;i++){
            gain[0]+=gain[i];
            if(gain[0]>highestPoint){
                highestPoint = gain[0];
            }
        }
        
        return highestPoint;
    }
}