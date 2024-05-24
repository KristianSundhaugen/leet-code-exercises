using System.Collections;

namespace Recap
{
    public class Test
    {
        public static void Main()
        {

        }

        public static int CalPoints(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            foreach(var operation in operations){
                if(int.TryParse(operation, out int number)){
                    stack.Push(number);
                } else if (operation == "D"){
                    int lastValue = stack.Count > 0 ? stack.Peek() : 0;
                    stack.Push(lastValue*2);
                } else if(operation == "C"){
                    if (stack.Count > 0){
                        stack.Pop();
                    }
                } else if(operation == "+"){
                    int lastValue = stack.Count > 0 ? stack.Pop() : 0;
                    int secondLastValue = stack.Count > 0 ? stack.Pop() : 0;

                    int sum = lastValue + secondLastValue;

                    stack.Push(secondLastValue);
                    stack.Push(lastValue);
                    stack.Push(sum);
                }
            }

            int totalPoints = 0;
            while(stack.Count > 0){
                totalPoints += stack.Pop();
            }
            return totalPoints;
        }
    }
}