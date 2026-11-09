public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l = 0;

        char[] arrS1 = s1.ToCharArray();

        Array.Sort(arrS1);

        for (int r = s1.Length - 1; r < s2.Length; r++) {
            
            char[] arr = new char[s1.Length];

            int j = 0;

            while (j <= r - l) {
                arr[j] = s2[j + l];
                j++;
            }

            Array.Sort(arr);

            if (arr.AsSpan().SequenceEqual(arrS1)) {
                return true;
            } else {
                l++;
            }
        }

        return false;
    }
}
