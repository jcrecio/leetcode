public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double GetMedian(int[] mergedArray)
        {
            if (mergedArray.Length % 2 == 0)
            {
                return (double)(mergedArray[(mergedArray.Length - 1) / 2] + mergedArray[mergedArray.Length / 2]) / 2;
            }

            return mergedArray[mergedArray.Length / 2];
        }
        
        
        if (nums1.Length == 0 && nums2.Length > 0) return GetMedian(nums2);
        if (nums2.Length == 0 && nums1.Length > 0) return GetMedian(nums1);
        int[] a = nums1, b = nums2;
        if (a[^1] < b[0]) (a, b) = (b, a);
        while (a[^1] > b[0])
        {
            (b[0], a[^1]) = (a[^1], b[0]);
            int posB = 0, posA = a.Length - 1;
            if (b.Length > 1) while (posB < b.Length - 1 && b[posB + 1] < b[posB])
            {
                (b[posB], b[posB + 1]) = (b[posB + 1], b[posB]);
                posB++;
            }
            if (a.Length > 1) while (posA > 0 && a[posA - 1] > a[posA])
            {
                (a[posA - 1], a[posA]) = (a[posA], a[posA - 1]);
                posA--;
            }
        }

        var mergedArray = new int[a.Length + b.Length];
        Array.Copy(a, mergedArray, a.Length);
        Array.Copy(b, 0, mergedArray, a.Length, b.Length);

        return GetMedian(mergedArray);
    }
}

