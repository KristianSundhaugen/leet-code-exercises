package ContainsDuplicate;
public class Main {
    public static void main(String[] args) {
        int[] nums1 = {1, 2, 3, 1};
        Solution solution1 = new Solution();
        boolean result1 = solution1.containsDuplicate(nums1);
        System.out.println(result1); // Output: true

        int[] nums2 = {1, 2, 3, 4};
        Solution solution2 = new Solution();
        boolean result2 = solution2.containsDuplicate(nums2);
        System.out.println(result2); // Output: false

        int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Solution solution3 = new Solution();
        boolean result3 = solution3.containsDuplicate(nums3);
        System.out.println(result3); // Output: true
    }
}
