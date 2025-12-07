public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Helper(nums, result, new List<int>(), new bool[nums.Length]);
        return result;
    }

    private void Helper(int[] nums, IList<IList<int>> result, List<int> current, bool[] visited){
        int n = nums.Length;
        if(current.Count == n){
            result.Add(new List<int>(current));
            return;
        }
        for(int i = 0; i < n; i++){
            if(visited[i] == false){
                visited[i] = true;
                current.Add(nums[i]);
                Helper(nums, result, current, visited);
                // Backtracking
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }
        }
    }
}