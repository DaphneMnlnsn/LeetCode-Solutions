public class Solution {
    public int LengthOfLastWord(string s) {
        string last = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).LastOrDefault();

        return last.Length;
    }
}