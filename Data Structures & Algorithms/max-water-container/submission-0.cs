public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            // Tính chiều cao thấp hơn giữa hai cột
            int currentHeight = Math.Min(heights[left], heights[right]);
            
            // Tính diện tích và cập nhật maxArea nếu lớn hơn
            int currentArea = currentHeight * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            // Di chuyển con trỏ đang chỉ vào cột thấp hơn
            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;
    }
}