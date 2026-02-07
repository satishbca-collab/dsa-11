public class Solution {
    public List<int> bfs(List<List<int>> adj) {
        // code here
        List<int> result = new List<int>();
        int numberOfVertices = adj.Count;
        int startingVertex = 0;
        
        bool[] visited = new bool[numberOfVertices];
        Queue<int> queue = new Queue<int>();

        visited[startingVertex] = true;
        queue.Enqueue(startingVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            result.Add(vertex);

            foreach (int neighbor in adj[vertex])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
        return result;
    }
}