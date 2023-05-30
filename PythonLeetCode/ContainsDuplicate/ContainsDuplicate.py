#Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
#https://leetcode.com/problems/contains-duplicate/

class Solution:
    def containsDuplicate(self, nums) -> bool:
        hashset = set()

        for n in nums:
            if n in hashset:
                return True
            hashset.add(n)
        return False

# Create an instance of the Solution class
solution = Solution()

# Test 1
nums = [1, 2, 3, 1]
result1 = solution.containsDuplicate(nums)
print(f"Test 1: {result1}") #To pass test, should output true

# Test 2
nums = [1,2,3,4]
result2 = solution.containsDuplicate(nums)
print(f"Test 2: {result2}") #To pass test, should output false

# Test 3
nums = [1,1,1,3,3,4,3,2,4,2]
result3 = solution.containsDuplicate(nums)
print(f"Test 3: {result3}") #To pass test, should output true
