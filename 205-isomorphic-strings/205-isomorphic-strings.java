class Solution {
    public boolean isIsomorphic(String s, String t) {
        HashMap<Character, Character> charMap = new HashMap<>();
        HashSet<Character> charSet = new HashSet<>();
        
        for(int i=0; i<s.length(); i++){
            char sChar = s.charAt(i);
            char tChar = t.charAt(i);
            
            // if s letter already mapped, check mapping
            if(charMap.containsKey(sChar)){
                if(charMap.get(sChar) != tChar)
                    return false;
            }
            // else check if tChar has been mapped to a diff value for a new sChar
            else if(charSet.contains(tChar)){
                return false;
            }
            // complete new entry add
            else{
                charMap.put(sChar, tChar);
                charSet.add(tChar);
            }
        }
        
        return true;
    }
}