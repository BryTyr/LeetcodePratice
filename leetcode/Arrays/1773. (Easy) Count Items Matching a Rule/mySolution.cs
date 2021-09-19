public class Solution {
    /*
    You are given an array items, where each items[i] = [typei, colori, namei] describes the type, color, and name of the ith item.
	You are also given a rule represented by two strings, ruleKey and ruleValue.

	The ith item is said to match the rule if one of the following is true:

	ruleKey == "type" and ruleValue == typei.
	ruleKey == "color" and ruleValue == colori.
	ruleKey == "name" and ruleValue == namei.
	
	Return the number of items that match the given rule.
    */
	
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        Dictionary<string,int> ruleIndexes = new Dictionary<string,int>(){
            {"type", 0},
            {"color",1}, 
            {"name", 2}
        };
        
        int targetRuleIndex = ruleIndexes[ruleKey];
        int matches = 0;
        
        foreach(IList<string> productList in items){
            if(productList[targetRuleIndex] == ruleValue){
                matches+= 1;
            }
            continue;
        }
        
        return matches;
    }
}