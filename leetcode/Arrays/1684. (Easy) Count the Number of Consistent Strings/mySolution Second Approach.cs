/*
You are given a string allowed consisting of distinct characters and an array of strings words. 
A string is consistent if all characters in the string appear in the string allowed.

Return the number of consistent strings in the array words.

*/

public class Solution {
     public int CountConsistentStrings(string allowed, string[] words) {
        
        Dictionary<char,bool> allowedHash = new Dictionary<char,bool>();
        int invalidCount = 0;
         
        foreach (char c in allowed)
        {
            allowedHash[c] = true;
        }
        
        foreach (string word in words)
        {
            foreach (char letter in word)
            {
				// contains key is O(1) lookup aka an efficiency monster!
                if (!allowedHash.ContainsKey(letter)){
                    invalidCount++;
                    break;
                }
            }
        }
        
        return words.Length - invalidCount;
    }
}