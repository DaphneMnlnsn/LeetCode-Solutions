public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int k = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val){
                nums[i] = int.MaxValue;
            }
            else{
                k++;
            }
        }

        nums.Sort();

        return k;
    }
}