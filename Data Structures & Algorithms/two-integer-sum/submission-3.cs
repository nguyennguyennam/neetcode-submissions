public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary lưu: Key = Giá trị của số, Value = Chỉ số (index) của số đó
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int remain = target - nums[i];

            // Kiểm tra xem số còn thiếu (remain) đã xuất hiện trước đó chưa
            if (dict.ContainsKey(remain)) {
                // Trả về chỉ số của số đã lưu và chỉ số hiện tại i
                return new int[] { dict[remain], i };
            }

            // Nếu chưa thấy remain, lưu số hiện tại vào Dictionary 
            // để các số sau có thể tìm thấy nó
            if (!dict.ContainsKey(nums[i])) {
                dict[nums[i]] = i;
            }
        }
        
        return new int[0]; // Trả về mảng rỗng nếu không tìm thấy cặp nào
    }
}