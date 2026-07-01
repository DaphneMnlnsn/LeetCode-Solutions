public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        List<int> numberList = [];

        while(x > 0){
            numberList.Add(x % 10);
            x /= 10;
        }

        int[] numberArray = numberList.ToArray();
        int[] origArray = (int[])numberArray.Clone();
        Array.Reverse(numberArray);

        for(int i=0; i < origArray.Length; i++){
            if(origArray[i] != numberArray[i]){
                return false;
            }
        }

        return true;
    }
}