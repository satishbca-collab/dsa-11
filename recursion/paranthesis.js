/**
 * @param {number} n
 * @return {string[]}
 */
var generateParenthesis = function(n) {
    const result = [];
    Helper(n,0,0,result, "");
    return result
};

function Helper(n, open, close, result, current){
    if(close === n){
        result.push(current);
        return;
    }

    if(open < n){
        Helper(n, open + 1, close, result, current + "(");
    }

    if(close < open){
        Helper(n, open, close + 1, result, current + ")");
    }
}