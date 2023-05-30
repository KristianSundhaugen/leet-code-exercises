#Given two strings s and t, return true if t is an anagram of s, and false otherwise
#https://leetcode.com/problems/valid-anagram/
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        countS, countT = {}, {}

        for i in range(len(s)):
            countS[s[i]] = 1 + countS.get(s[i], 0)
            countT[t[i]] = 1 + countT.get(t[i], 0)
        return countS == countT


# Create an instance of the Solution class
solution = Solution()

# Test 1
s1 = "anagram"
t1 = "nagaram"
result1 = solution.isAnagram(s1, t1)
print(f"Test 1: {result1}")  # Output: True if anagram, False otherwise

# Test 2
s2 = "rat"
t2 = "car"
result2 = solution.isAnagram(s2, t2)
print(f"Test 2: {result2}")  # Output: True if anagram, False otherwise
