public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int count = 0;
        int max = 0;

        for (int i = 0; i < n; i++) {
            if (nums[i] == 0) {
                max = Math.Max(max, count);
                count = 0;               
            } else {
                count += 1;
            }
        }

    

        return Math.Max(max, count);
    }
}