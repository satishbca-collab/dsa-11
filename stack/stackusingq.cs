public class MyStack {
    private Queue<int> q1;
    private Queue<int> q2;

    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
    }
    
    public int Pop() {
        while(q1.Count > 1){
            q2.Enqueue(q1.Dequeue());
        }
        int result = q1.Dequeue();
        var temp = q1;
        q1 = q2;
        q2 = temp;
        return result;
    }
    
    public int Top() {
        while(q1.Count > 1){
            q2.Enqueue(q1.Dequeue());
        }
        int result = q1.Dequeue();
        q2.Enqueue(result);
        var temp = q1;
        q1 = q2;
        q2 = temp;
        return result;
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */