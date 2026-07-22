public class Solution {
    public int LengthOfLastWord(string s) {
        string last = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).LastOrDefault();

        int count = 0;
        foreach(char letter in last){
            count++;
        }

        return count;
    }
}