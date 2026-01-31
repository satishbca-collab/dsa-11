class Solution {
    public static boolean checkRedundancy(String s) {
        Stack<Character> st = new Stack<>();

        for (char ch : s.toCharArray()) {
            if (ch == ')') {
                int operators = 0;

                while (st.peek() != '(') {
                    char top = st.pop();
                    if (top == '+' || top == '-' || top == '*' || top == '/')
                        operators++;
                }
                st.pop(); // remove '('

                if (operators == 0) return true; // redundant
            }
            else {
                st.push(ch);
            }
        }
        return false;
    }
}
