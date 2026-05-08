public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();
        bool flag = false;
        for (int i = 0; i < nums.Length; i++) {
            if (dup.Contains(nums[i])) {
                flag = true;
            }
            else {
                dup.Add(nums[i]);
            }
        }
        return flag;
    }
}