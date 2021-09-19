public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] sortedArr = new char[indices.Length];
        char[] characters = s.ToCharArray();
        string outputStr = "";
        
        if(indices.Length<=1){
            return s;
        }
        
        for(int i=0;i<indices.Length;i++){
            sortedArr[i] = characters[indices[i]];
        }
        
        for(int i=0;i<sortedArr.Length;i++){
            outputStr+=sortedArr[i];
        }
        
        return outputStr;
    }
}