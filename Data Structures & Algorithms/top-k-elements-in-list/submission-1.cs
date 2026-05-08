public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int n in nums) {
            if (!counts.ContainsKey(n)) counts[n] = 0;
            counts[n]++;
        }

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (var entry in counts) {
            minHeap.Enqueue(entry.Key, entry.Value);
            
            if (minHeap.Count > k) {
                minHeap.Dequeue();
            }
        }

        // 3. Lấy kết quả từ Heap: O(K log K)
        int[] result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }
}