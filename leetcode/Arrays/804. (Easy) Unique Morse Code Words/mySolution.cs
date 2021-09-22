/*
International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:

'a' maps to ".-",
'b' maps to "-...",
'c' maps to "-.-.", and so on.
For convenience, the full table for the 26 letters of the English alphabet is given below:

[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.

For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
Return the number of different transformations among all words we have.

*/
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        Dictionary<string,string> transformations = new Dictionary<string,string>();
        string[] morseCodeArr = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        
        foreach(var word in words){
            char[] charsArr = word.ToCharArray();
            string transformation = "";
            foreach(char letter in charsArr){
                transformation += morseCodeArr[((int)letter % 32)-1];
            }
            
            if(!transformations.ContainsKey(transformation))
                transformations[transformation] = word;
        }
        
        return transformations.Count();
    }
}