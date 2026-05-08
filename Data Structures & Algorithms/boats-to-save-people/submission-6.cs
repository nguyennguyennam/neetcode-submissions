public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int total = people.Length;
        int count = 0;
        int start = 0;
        int last = people.Length - 1 ;
        while (start <= last) {
            if ((people[last] + people[start]) > limit) {
                count++;
                last--;
            }
            else {
                count++;
                last--;
                start++;
            }
        }
       return count;
    }
}