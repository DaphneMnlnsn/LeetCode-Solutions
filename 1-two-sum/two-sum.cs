public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] origNums = nums.ToArray();

        Array.Reverse(nums);
        
        int firstNum = int.MinValue;
        int secondNum = int.MinValue;

        for(int i = 0; i < nums.Length; i++) {

            firstNum = nums[i];
            
            for(int j = i+1; j < nums.Length; j++) {
                
                if(firstNum + nums[j] == target) {
                    secondNum = nums[j];
                    break;
                }
            }

            if(firstNum != int.MinValue && secondNum != int.MinValue){
                break;
            }
        }

        int answer1 = firstNum;
        int answer2 = secondNum;
        
        for(int i = 0; i < origNums.Length; i++) {
            
            if(answer1 == origNums[i] && firstNum == answer1) {
                firstNum = i;
                continue;
            }
            if(answer2 == origNums[i] && secondNum == answer2) {
                secondNum = i;
            }
            
        }
        
        int[] result = new int[]{firstNum, secondNum};
        Array.Sort(result);
        
        return result;

    }
}