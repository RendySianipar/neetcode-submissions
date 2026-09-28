public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int count = 0;
        int max = 0;

        for (int i = 0; i < n; i++) {
            if (nums[i] == 0) {
                if (count > max) {
                    max = count;
                }
                count = 0;
                continue;
            }

            count += 1;
        }

        if (count > max) {
            max = count;
        }

        return max;
    }
}