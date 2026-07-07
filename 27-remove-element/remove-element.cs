public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val){
                nums[i] = int.MaxValue;
            }
        }

        int k = 0;

        foreach(int count in nums){
            if(count != int.MaxValue){
                k ++;
            }
        }

        nums.Sort();

        return k;
    }
}