public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;

        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                if(nums[i] == nums[j]){
                    if(i == j){
                        continue;
                    }
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