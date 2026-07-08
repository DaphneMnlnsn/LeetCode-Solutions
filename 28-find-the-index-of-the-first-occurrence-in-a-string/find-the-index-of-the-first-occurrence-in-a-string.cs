public class Solution {
    public int StrStr(string haystack, string needle) {
        int index = -1;

        char[] haystackArray = haystack.ToCharArray();
        char[] needleArray = needle.ToCharArray();

        if(haystackArray.Length < needleArray.Length) return index;

        for(int i = 0; i < haystackArray.Length; i++){
            if(i > (haystackArray.Length - needleArray.Length) && index == -1) break;

            if(haystackArray[i] == needleArray[0] && index == -1){
                index = i;

                for(int j = 0; j < needleArray.Length; j++){
                    if(haystackArray[i + j] != needleArray[j]){
                        index = -1;
                        break;
                    }
                }
            }
        }

        return index;
    }
}