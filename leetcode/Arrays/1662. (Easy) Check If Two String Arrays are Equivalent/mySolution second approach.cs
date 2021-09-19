public class Solution {
    /*
     Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false                otherwise.

    A string is represented by an array if the array elements concatenated in order forms the string.
    
    
    notes: thought this woud be quicker as combining two for loops but leetcode says solution one is much faster
    */
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int stringId1 = 1;
        int stringId2 = 1;
        
        // while both string arrays not cycled through continue
        while(stringId1 < word1.Length || stringId2 < word2.Length){
            
            if(stringId1 < word1.Length){
                word1[0] += word1[stringId1];
                stringId1++;
            }
           
            if(stringId2 < word2.Length){
                word2[0] += word2[stringId2];
                stringId2++;
            }
            
            // if by chance same length and dont match, quit early
            if(word1[0].Length == word2.Length && word1[0] != word2[0]){
                return false;
            }
        }
        
        if(word1[0]!=word2[0]){
            return false;
        }
        else{
            return true;
        }
    }
}