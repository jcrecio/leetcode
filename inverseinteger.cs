public class Solution {
    public int Reverse(int x) {
        char[] xString;
        if (x < 0) xString = x.ToString().Substring(1).ToCharArray();
        else xString = x.ToString().ToCharArray();
        
        for (int i = 0; i < xString.Length/2; i++){
            var tmp = xString[i];
            xString[i] = xString[xString.Length - 1 - i];
            xString[xString.Length - 1 - i] = tmp;
        }
        int.TryParse(new string(xString), out int result);
        return x < 0 ? -result : result;
    }
}