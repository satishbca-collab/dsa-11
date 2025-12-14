public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Helper(candidates, target, result, 0, new List<int>());
        return result;
    }

    private void Helper(int[] candidates, int target, IList<IList<int>> result, int index, List<int> current){
        if(target == 0){
            // result found
            result.Add(new List<int>(current));
            return;
        }
        if(target < 0){
            // no more results
            return;
        }

        for(int i = index; i < candidates.Length; i++){
            current.Add(candidates[i]);
            Helper(candidates, target - candidates[i], result, i, current);
            current.RemoveAt(current.Count-1);
        }
    }
}
/**
index   target  i   current
0       7       0   [] -> [2]
0       5       0   [2] -> [2,2]
0       3       0   [2,2]
1       0       1   [2,2,3]
*/