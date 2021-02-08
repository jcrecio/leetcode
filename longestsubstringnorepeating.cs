public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int max = 0, i = 0, j = 0;
    
        while (i < s.Length && j < s.Length)
        {
            if (!set.Contains(s[j]))
            {
                set.Add(s[j++]);
                max = Math.Max(max, j - i);
                continue;
            }
            set.Remove(s[i++]);
        }

        return max;
    }
}