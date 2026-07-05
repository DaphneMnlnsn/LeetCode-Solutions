public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string output = "";

        if(strs.Length == 0) return output;

        for(int i = 0; i < strs[0].Length; i++){
            if(strs[0] == ""){
                break;
            }
            if(strs.Length == 1){
                output += strs[0][i];
                break; 
            }
            for(int j = 1; j < strs.Length; j++){
                if(i >= strs[j].Length || strs[0][i] != strs[j][i]){
                    return output;
                }
            }
            output += strs[0][i];
        }

        return output;
    }
}