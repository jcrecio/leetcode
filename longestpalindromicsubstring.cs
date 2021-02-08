public string LongestPalindrome(string s) {
        var len = s.Length;

        if (s == "") return "";
        if (len == 1) return s;
        int max = 0;
        int i_max = 0;
        int j_max = 0;

        for (int i = 0; i < len; i++)
        {
            if (max >= len - i)
            {
                return s.Substring(i_max, j_max);
            }
            for (int j = len; j > i; j--)
            {
                if (IsPalindrome(s,i,j-1))
                {
                    if (j - i > max)
                    {
                        i_max = i;
                        j_max = j;
                        max = j - i;
                    }
                }
            }
        }

        return max == 0 ? s[0].ToString() : s.Substring(i_max, j_max);
    }

    public static bool IsPalindrome(string s, int x, int y)
    {
        for (int i = x; i <= y; i++)
        {
            if (s[i] != s[s.Length - i - 1]) return false;
        }

        return true;
    }