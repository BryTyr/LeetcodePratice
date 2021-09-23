/*
You are given a string allowed consisting of distinct characters and an array of strings words. 
A string is consistent if all characters in the string appear in the string allowed.

Return the number of consistent strings in the array words.

*/

public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int invalidCount = 0;
        foreach(string strVal in words){
            char[] charsArr = strVal.ToCharArray();
            foreach(char charVal in charsArr){
                if(!allowed.Contains(charVal)){
                    invalidCount++;
                    break;
                }
            }
        }
    
        return words.Length - invalidCount;
    }
}