/**
 * @param {string} text1
 * @param {string} text2
 * @return {number}
 */
var longestCommonSubsequence = function(text1, text2) {
    const m = text1.length, n = text2.length;
    const memo = Array.from({length: m+1}, () => Array(n+1).fill(-1));
    helper(text1, text2, m, n, memo);
    return memo[m][n];
};

function helper(text1, text2, i, j, memo){
    const m = text1.length, n = text2.length;
    if(i <= 0 || j <= 0) return 0;
    if(memo[i][j] != -1) return memo[i][j];
    if(text1[i-1] == text2[j-1]) memo[i][j] = 1 + helper(text1, text2, i-1, j-1, memo);
    else memo[i][j] = Math.max(helper(text1, text2, i-1, j, memo), helper(text1, text2, i, j-1, memo));
    return memo[i][j];
}