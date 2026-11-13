public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int c = n - 1;
        int row = 0;

        while (row < m && c >= 0) {
            if (matrix[row][c] > target) {
                c--;
            } else if (matrix[row][c] < target) {
                row++;
            } else {
                return true;
            }
        }

        return false;
    }
}
