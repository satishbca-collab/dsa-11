public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        
        foreach (string token in tokens) {
            if (token == "+" || token == "-" || token == "*" || token == "/") {
                int b = stack.Pop();
                int a = stack.Pop();
                switch (token) {
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "-":
                        stack.Push(a - b);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    case "/":
                        stack.Push(a / b); // Integer division
                        break;
                }
            } else {
                stack.Push(int.Parse(token));
            }
        }
        
        return stack.Pop();
    }
}