using System;

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int num in count) {
            if (num != 0) {
                return false;
            }
        }

        return true;
    }

    public static void Main(string[] args) {
        string s1 = "anagram";
        string t1 = "nagaram";
        Solution solution1 = new Solution();
        bool result1 = solution1.IsAnagram(s1, t1);
        Console.WriteLine(result1); // Output: True

        string s2 = "rat";
        string t2 = "car";
        Solution solution2 = new Solution();
        bool result2 = solution2.IsAnagram(s2, t2);
        Console.WriteLine(result2); // Output: False
    }
}
