class Solution {
    public boolean isAnagram(String s, String t) {
        
        if(s.length() != t.length())
            return false;
        
        Map<Character, Integer> sLetterFreq = new HashMap<>();
        
        for(char letter : s.toCharArray())
            sLetterFreq.put(letter, sLetterFreq.getOrDefault(letter, 0) + 1);
        
        for(char letter : t.toCharArray()){
            if(!sLetterFreq.containsKey(letter)){
                return false;
            }
            sLetterFreq.put(letter, sLetterFreq.getOrDefault(letter, 0) - 1);
            
            if(sLetterFreq.get(letter) < 0)
                return false;
        }
        
        return true;
    }
}