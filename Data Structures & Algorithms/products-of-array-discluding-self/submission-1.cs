public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int [] results = [];
        bool containsZero = false;
        int countZero = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                product *= nums[i];
            }
            else {
                containsZero = true;
                countZero++;
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!containsZero) {
                results = [..results, product/nums[i]];
            }
            else {
                if (countZero >= 2) {
                    return new int[nums.Length];
                }
                else {
                    if (nums[i] != 0) {
                    results = [..results, 0];
                }
                else {
                    results = [..results, product];
                    }
                }
            }
        }
        return results;
    }
}
