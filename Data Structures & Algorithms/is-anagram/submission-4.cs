public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charactersS = s.ToCharArray();
        char[] charactersT = t.ToCharArray();
        Array.Sort(charactersS);
        Array.Sort(charactersT);
        Console.WriteLine(charactersS);
        Console.WriteLine(charactersT);
        return charactersS.SequenceEqual(charactersT);
    }
}
