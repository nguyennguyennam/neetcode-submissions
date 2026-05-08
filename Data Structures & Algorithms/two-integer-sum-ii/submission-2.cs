public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int last = numbers.Length - 1;
        while (start <= last) {
            if (numbers[start] + numbers[last] == target) {
                return new int[] {start + 1, last + 1};
            }
            else if (numbers[start] + numbers[last] > target) {
                last--;
            }
            else if (numbers[start] + numbers[last] < target) {
                start++;
            }
        }
        return new int[] {-1, -1};
    }
}
