public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        if(x == 0) return true;

        int y = x;
        int reversed = 0;

        while(x > 0){
            reversed = reversed * 10 + (x % 10);
            x /= 10;
        }

        while(y > 0){
            if(y % 10 != reversed % 10) {
                return false;
            }
            else{
                y /= 10;
                reversed /= 10;
            }
        }

        return true;
    }
}