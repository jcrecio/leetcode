public class Solution {
    public string Convert(string s, int numRows) {
        if (s.Length == 1) return s;
        if (numRows == 1) return s;

        char[,] M = new char[s.Length, numRows];
        int row = 0;
        int column = 0;
        int maxPartialColumn = numRows == 2 ? 0 : numRows - 1
            , maxUnpartialColumn = numRows == 2 ? 1 : numRows - 2;
        bool partial = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (!partial)
            {
                M[row, column] = s[i];
                if (column == maxPartialColumn)
                {
                    row++;
                    column = maxUnpartialColumn;
                    partial = true;
                }
                else column++;
            }
            else
            {
                M[row, column] = s[i];
                row++;
                if (column <= 1)
                {
                    column = 0;
                    partial = false;
                }
                else column--;
            }
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < M.GetLength(1); i++)
        {
            for (int j = 0; j < M.GetLength(0); j++)
            {
                if (M[j, i] != default) sb.Append(M[j, i]);
            }
        }

        return sb.ToString();
    }
}