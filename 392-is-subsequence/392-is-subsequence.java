class Solution {
    public boolean isSubsequence(String s, String t) {
        int sIndex = 0;
        
        if(s == t || s.length() == 0) return true;
        
        for(int tIndex = 0; tIndex < t.length(); tIndex++){
            
            // check current letter in t against s
            if(s.charAt(sIndex) == t.charAt(tIndex))
                sIndex++;
            
            // all letters matched/found. Return true
            if(sIndex >= s.length())
                return true;
            
        }
        
        // check if last letter was the math
        return false;
    }
}