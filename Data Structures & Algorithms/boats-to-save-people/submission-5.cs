public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int total = people.Length;
        bool[] visited = new bool[total];
        int count = 0;
        int start = 0;
        int last = people.Length - 1 ;
        while (start < last) {
            if ((people[last] + people[start]) > limit) {
                visited[last] = true;
                count++;
                last--;
            }
            else {
                visited[start] = visited[last] = true;
                count++;
                last--;
                start++;
            }

        }
        if (!visited[start]) return count + 1;
        else return count;
    }
}