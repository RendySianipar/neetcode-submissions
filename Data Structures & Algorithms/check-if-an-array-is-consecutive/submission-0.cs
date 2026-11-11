public class Solution {
    public bool isConsecutive(int[] nums) {
        int j = 0;
        int n = nums.Length;

        int min = nums[0];

        while (j < nums.Length) {
            min = Math.Min(min, nums[j]);
            j++;
        }

        int k = 0;
        int sumA = 0;
        int sumB = 0;

        int max = min + n - 1;

        while (min <= max) {
            sumB += min;
            sumA += nums[k];
            k++;
            min++;
        }

        return sumA == sumB;
    }
}
