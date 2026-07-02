public class Solution {
    public int RomanToInt(string s) {
        char[] roman = ['I','V','X','L','C','D','M'];
        int[] numbers = [1,5,10,50,100,500,1000];

        char[] input = s.ToCharArray();
        int output = 0;

        for(int i = 0; i < input.Length; i++){
            if(i != 0) {
                if(input[i] == roman[1] && input[i-1] == roman[0]) {
                    output += 3;
                    continue;
                }
                if(input[i] == roman[2] && input[i-1] == roman[0]) {
                    output += 8;
                    continue;
                }
                if(input[i] == roman[3] && input[i-1] == roman[2]) {
                    output += 30;
                    continue;
                }
                if(input[i] == roman[4] && input[i-1] == roman[2]) {
                    output += 80;
                    continue;
                }
                if(input[i] == roman[5] && input[i-1] == roman[4]) {
                    output += 300;
                    continue;
                }
                if(input[i] == roman[6] && input[i-1] == roman[4]) {
                    output += 800;
                    continue;
                }
            }
            
            for(int j = 0; j < roman.Length; j++) {
                if(input[i] == roman[j]){
                    output += numbers[j];
                }
            }
        }

        return output;
    }
}