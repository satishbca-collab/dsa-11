public class NumMatrix {
    private int[][] prefixSum;

    public NumMatrix(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        prefixSum = new int[m][];

        for(int i = 0; i < m; i++){
            prefixSum[i] = new int[n];
            for(int j = 0; j < n; j++){
                prefixSum[i][j] = matrix[i][j];
            }
        }

        for(int i = 1; i < m; i++){
            prefixSum[i][0] += prefixSum[i-1][0];
        }

        for(int j = 1; j < n; j++){
            prefixSum[0][j] += prefixSum[0][j-1];
        }

        for(int i = 1; i < m; i++){
            for(int j = 1; j < n; j++){
                prefixSum[i][j] += prefixSum[i-1][j] + prefixSum[i][j-1] - prefixSum[i-1][j-1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int res = prefixSum[row2][col2];

        if(row1 > 0){
            res -= prefixSum[row1-1][col2];
        }

        if(col1 > 0){
            res -= prefixSum[row2][col1-1];
        }

        if(row1 > 0 && col1 > 0){
            res += prefixSum[row1-1][col1-1];
        }

        return res;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */