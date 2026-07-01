public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x == 0) return true;

        List<int> numberList = [];

        int y = x;

        while(y > 0){
            numberList.Add(y % 10);
            y /= 10;
        }

        int[] numberArray = numberList.ToArray();
        long reversedNum = long.Parse(string.Concat(numberArray));

        if(x != reversedNum){
            return false;
        }

        return true;
    }
}