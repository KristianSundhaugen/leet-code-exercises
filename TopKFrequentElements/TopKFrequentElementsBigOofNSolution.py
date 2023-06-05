class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        #Make the frequency of "buckets" to count in be same as length of nums, pluss 1, becasuse we are not interesed in 0 count
        freq = [[] for i in range(len(nums) + 1)]

        for n in nums:
            #Add one or init with value of one for where N matches, if n isn't set in count, returns 0 from .get
            count[n] = 1 + count.get(n, 0)
        for n, c in count.items():
            #Append the values counted to freq
            freq[c].append(n)

        res = []
        #Loop through length of freq, skipping 0, in decending order
        for i in range(len(freq) - 1, 0, -1):
            for n in freq[i]:
                #Add when found N to result
                res.append(n)
                #If result matches K, return 
                if len(res) == k:
                    return res

        # O(n)