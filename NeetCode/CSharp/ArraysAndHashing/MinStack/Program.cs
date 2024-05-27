public class Solution
{
    public static void Main()
    {
        MinStack obj = new MinStack();
        obj.Push(5);
        obj.Pop();
        int param_3 = obj.Top();
        int param_4 = obj.GetMin();

    }
}

public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;


    public MinStack()
    {

        this.stack = new Stack<int>();
        this.minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
        else
        {
            minStack.Push(minStack.Peek());
        }

        minStack.Push(val);
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}