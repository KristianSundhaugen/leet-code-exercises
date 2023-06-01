#Given an array of strings strs, group the anagrams together. You can return the answer in any order.
#https://leetcode.com/problems/group-anagrams/
from collections import defaultdict

def groupAnagrams(strs):
    # Create a dictionary to store groups of anagrams
    groups = defaultdict(list)

    # Iterate over each string in the input array
    for word in strs:
        # Sort the characters of the string to use as a key
        key = ''.join(sorted(word))
        # Add the string to the corresponding group
        groups[key].append(word)

    # Convert the dictionary values to a list and return
    return list(groups.values())

# Example usage
strs = ["eat","tea","tan","ate","nat","bat"]
result = groupAnagrams(strs)
print(result)  # Output: [["eat","tea","ate"],["tan","nat"],["bat"]]

strs = [""]
result = groupAnagrams(strs)
print(result)  # Output: [[""]]

strs = ["a"]
result = groupAnagrams(strs)
print(result)  # Output: [["a"]]
