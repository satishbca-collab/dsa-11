class Solution {
    public bool isPalindrome(string s) {
		int n = s.Length;
		if(n <= 1) return true;
		return Helper(s, 0, n - 1);
	}

	private bool Helper(string s, int left, int right){
		if(left >= right) return true;
		if(s[left] == s[right]) return Helper(s, left + 1, right - 1);
		return false;
	}

}
