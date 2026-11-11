public class Solution {
    public int SumOfDigits(int[] nums) {
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++) {
            min = Math.Min(min, nums[i]);
        }

        int sum = 0;

        while (min > 0) {
            sum += min % 10;

            min /= 10;
        }

         return sum % 2 == 0 ? 1 : 0;
    }
}
