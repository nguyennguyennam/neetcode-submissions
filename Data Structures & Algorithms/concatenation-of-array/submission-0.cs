public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int [] copy = nums;
        return [..nums, ..copy];
    }
}