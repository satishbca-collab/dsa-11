public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Use hash sets to keep track of seen numbers
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char current = board[i][j];
                if (current != '.') {
                    // Create unique keys for rows, columns, and sub-grids
                    string rowCheck = $"row-{i}-{current}";
                    string colCheck = $"col-{j}-{current}";
                    string boxCheck = $"box-{i/3}-{j/3}-{current}";

                    // If any key is already in the set, it's invalid
                    if (seen.Contains(rowCheck) || seen.Contains(colCheck) || seen.Contains(boxCheck)) {
                        return false;
                    }

                    // Add keys to the set
                    seen.Add(rowCheck);
                    seen.Add(colCheck);
                    seen.Add(boxCheck);
                }
            }
        }

        return true;
    }
}