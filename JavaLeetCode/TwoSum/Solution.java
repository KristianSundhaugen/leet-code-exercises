package TwoSum;

import java.util.HashMap;

public class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> hashMap = new HashMap<>();

        int index = 0;
        for (int num : nums) {
            int n = nums[index];
            int x = target - num;
            if (hashMap.containsKey(x)) {
                return new int[]{hashMap.get(x), index};
            }
            hashMap.put(n, index);
            index++;
        }

        return null;
    }
}