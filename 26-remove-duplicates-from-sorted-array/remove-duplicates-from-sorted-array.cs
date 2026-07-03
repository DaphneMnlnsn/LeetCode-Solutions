public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;

        for(int i = 0; i < nums.Length; i++){
            for(int j = i+1; j < nums.Length; j++){
                if(nums[i] == nums[j]){
                    nums[i] = int.MaxValue;
                }
            }
        }

        Array.Sort(nums);

        foreach(int num in nums){
            if(num != int.MaxValue){
                k++;
            }
        }
        return k;
    }
}