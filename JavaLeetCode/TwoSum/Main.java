package TwoSum;

public class Main {
    public static void main(String[] args) {

        Solution solution = new Solution();

        int[] nums1 = {2,7,11,15};
        int target1 = 9;
        int[] result1 = solution.twoSum(nums1, target1);
        System.out.println("Test 1: [" + result1[0] + ',' + result1[1] + "]"); // Output: [0,1]

        int[] nums2 = {3,2,4};
        int target2 = 6;
        int[] result2 = solution.twoSum(nums2, target2);
        System.out.println("Test 2: [" + result2[0] + ',' + result2[1] + "]"); // Output: [1,2]

        int[] nums3 = {3,3};
        int target3 = 6;
        int[] result3 = solution.twoSum(nums3, target3);
        System.out.println("Test 3: [" + result3[0] + ',' + result3[1] + "]"); // Output: [0,1]
    }
}
