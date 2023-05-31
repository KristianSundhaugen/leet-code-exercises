#Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
#You may assume that each input would have exactly one solution, and you may not use the same element twice.
#You can return the answer in any order.
#https://leetcode.com/problems/two-sum/

class Solution(object):
    def twoSum(self, nums, target):
        hashset = {}

        for index, n in enumerate(nums):
            x = target - n
            if x in hashset:
                return [hashset[x], index]
            hashset[n] = index
        return False

solution = Solution()

# Test 1
nums = [2,7,11,15]
target = 9
result1 = solution.twoSum(nums, target)
print(f"Test 1: {result1}")  # Output: [0,1] Because nums[0] + nums[1] == 9, we return [0, 1].

# Test 2
nums = [3,2,4]
target = 6
result2 = solution.twoSum(nums, target)
print(f"Test 2: {result2}")  # Output: [1,2]

# Test 2
nums = [3,3]
target = 6
result3 = solution.twoSum(nums, target)
print(f"Test 3: {result3}")  # Output: [0,1]