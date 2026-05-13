public class Solution {
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        int length = nums.Length;
        foreach (var num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num] += 1;
                if (dict[num] > length/2) {
                    return num;
                }
            }
            else {
                dict[num] = 1;
                if (dict[num] > length/2) {
                    return num;
                }
            }
        }
        return -1;
    }
}