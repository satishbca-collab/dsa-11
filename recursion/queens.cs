public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        var board = new char[n,n];
        for(int i = 0; i <n; i++){
            for(int j = 0; j < n; j++){
                board[i,j] = '.';
            }
        }
        helper(result, board, 0);
        return result;
    }

    private void helper(IList<IList<string>> result, char[,] board, int row){
        int n = board.GetLength(0);
        if(row == n){
            result.Add(construct(board));
            return;
        }
        for(int col = 0; col < n; col++){
            if(isSafe(board, row, col)){
                board[row,col] = 'Q';
                helper(result, board, row+1);
                // backtracking step
                board[row,col] = '.';
            }
        }
    }

    private bool isSafe(char[,] board, int row, int col){
        int n = board.GetLength(0);
        for(int i = row - 1; i >= 0; i--){
            if(board[i,col] == 'Q') return false;
        }

        for(int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--){
            if(board[i,j] == 'Q') return false;
        }

        for(int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++){
            if(board[i,j] == 'Q') return false;
        }

        return true;
    }

    private IList<string> construct(char[,] board){
        var result = new List<string>();
        int n = board.GetLength(0);
        for(int i = 0; i < n; i++){
            string s = string.Empty;
            for(int j = 0; j < n; j++){
                s += board[i,j];
            }
            result.Add(s);
        }
        return result;
    }
}