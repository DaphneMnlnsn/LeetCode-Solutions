public class Solution {
    public int RemoveElement(int[] nums, int val) {

        int k = 0;

        foreach(int num in nums){
            if(num != val) k++;
        }
        
        int unread = 0;

        for(int i = 0; i < k; i++){
            for(int j = unread; j < nums.Length; j++){
                unread++;
                if(nums[j] != val){
                    nums[i] = nums[j];
                    break;
                }
            }
            
        }

        return k;
    }
}