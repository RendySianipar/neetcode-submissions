public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> firstWord = new Dictionary<char, int>();
        Dictionary<char, int> secondWord = new Dictionary<char, int>();

        var firstWordChar = s.ToArray();
        var secondWordChar = t.ToArray();

        foreach (char c in firstWordChar) {
            if (!firstWord.ContainsKey(c)) {
                firstWord[c] = 1;
            } else {
                firstWord[c] += 1;
            }
        }

        foreach (char d in secondWordChar) {
            if (!secondWord.ContainsKey(d)) {
                secondWord[d] = 1;
            } else {
                secondWord[d] += 1;
            }
        }

        foreach (var fW in firstWord) {
            if (!(secondWord.ContainsKey(fW.Key) && secondWord[fW.Key] == fW.Value)) {
                return false;
            }
        }

        return true;
    }
}
