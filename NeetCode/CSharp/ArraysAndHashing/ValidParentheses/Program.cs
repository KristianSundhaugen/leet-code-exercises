public class Solution
{
    public static void Main()
    {

        bool result1 = IsValid("()");
        Console.WriteLine("{0}", result1);
        bool result2 = IsValid("()[]{}");
        Console.WriteLine("{0}", result2);
        bool result3 = IsValid("(]");
        Console.WriteLine("{0}", result3);
    }
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(c);
                    break;

                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(')
                        return false;
                    break;

                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[')
                        return false;
                    break;

                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{')
                        return false;
                    break;

                default:
                    return false; // For any invalid characters
            }
        }

        return stack.Count == 0;
    }
}