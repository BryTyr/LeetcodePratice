public class Solution {
    /*
     Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false                otherwise.

    A string is represented by an array if the array elements concatenated in order forms the string.   
    */
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string fullWord1 = "";
        string fullWord2 = "";
        
        foreach(var strVal in word1){
               fullWord1+= strVal; 
        }
        foreach(var strVal in word2){
            fullWord2 += strVal;
        }
        
        if(fullWord1==fullWord2){
            return true;
        }
        
        return false;
    }
}