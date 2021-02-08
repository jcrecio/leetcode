public class Solution {
    // Without converting the integer to string
    public bool IsPalindrome(int x) {
        if (x < 0) return false;

        int n = x;
        int positions = 0;

        while (n >= 10)
        {
            n = n / 10;
            positions++;
        }

        int accumulated = 0;
        List<int> partialResults = new List<int>();

        for (int i = positions; i >= 0; i--)
        {
            int prev = x / (int)Math.Pow(10, i);
            int partialResult = prev;
            
            if (accumulated > 0)
            {
                partialResult -= accumulated * 10;
            }
            accumulated = prev;
            partialResults.Add(partialResult);
        }

        for (int i = 0; i < partialResults.Count; i++)
        {
            if (partialResults[i] != partialResults[partialResults.Count - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}