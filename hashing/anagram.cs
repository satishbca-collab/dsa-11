public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] hash = new int[26];

        foreach(char c in s){
            int index = c-'a';
            hash[index]++;
        }

        foreach(char c in t){
            int index = c - 'a';
            if(hash[index] == 0){
                return false;
            }
            hash[index]--;
        }

        foreach(int value in hash){
            if(value != 0){
                return false;
            }
        }
        return true;
    }
}