public class MyHashSet {
    private readonly int numBuckets = 1000;
    private List<int>[] buckets;

    public MyHashSet() {
        buckets = new List<int>[numBuckets];
    }

    // Hàm băm đơn giản để tìm chỉ số thùng
    private int Hash(int key) => key % numBuckets;

    public void Add(int key) {
        int index = Hash(key);
        if (buckets[index] == null) {
            buckets[index] = new List<int>();
        }
        if (!buckets[index].Contains(key)) {
            buckets[index].Add(key);
        }
    }

    public void Remove(int key) {
        int index = Hash(key);
        if (buckets[index] != null) {
            buckets[index].Remove(key);
        }
    }

    public bool Contains(int key) {
        int index = Hash(key);
        return buckets[index] != null && buckets[index].Contains(key);
    }
}