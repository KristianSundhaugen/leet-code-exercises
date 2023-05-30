package ValidAnagram;

public class Main {
    public static void main(String[] args) {
        String s1 = "anagram";
        String t1 = "nagaram";
        Solution solution1 = new Solution();
        boolean result1 = solution1.isAnagram(s1, t1);
        System.out.println(result1); // Output: true

        String s2 = "rat";
        String t2 = "car";
        Solution solution2 = new Solution();
        boolean result2 = solution2.isAnagram(s2, t2);
        System.out.println(result2); // Output: false
    }
}
