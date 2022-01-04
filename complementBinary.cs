public class Solution {

    public int BitwiseComplementBinaryOperators(n) 
    {
        return n == 0 ? 1 : n ^ (((int)Math.Pow(2, Convert.ToString(n, 2).Length - 1) << 1) - 1);
    }

    public int BitwiseComplementManual(int n) {
        if (n == 0) return 1;
        if (n == 1) return 0;

        var directResult = 0;
        var m = n;
        var position = 0;

        while (m != 0 && m != 1)
        {
            var remainder = m % 2;
            if (remainder == 0)
            {
                // we add when it is 0 because it is the complementary
                directResult += (int)Math.Pow(2, position);
            }
            m /= 2;

            position++;
        }

        if (m == 0)
        {
            // we add when it is 0 because it is the complementary
            directResult += (int)Math.Pow(2, position);
        }
        
        return directResult;
    }
}