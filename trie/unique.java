

//User function Template for Java

class Solution {
    static String[] findPrefixes(String[] arr, int N) {
        // code here
        Trie trie = new Trie();
        for (String word : arr) {
            trie.insert(word);
        }

        String[] result = new String[N];
        for (int i = 0; i < N; i++) {
            result[i] = trie.getUniquePrefix(arr[i]);
        }
        return result;
    }
};

class TrieNode {
    Map<Character, TrieNode> children = new HashMap<>();
    int frequency;
}

class Trie {
    TrieNode root = new TrieNode();

    void insert(String word) {
        TrieNode node = root;
        for (char ch : word.toCharArray()) {
            node.children.putIfAbsent(ch, new TrieNode());
            node = node.children.get(ch);
            node.frequency++;
        }
    }

    String getUniquePrefix(String word) {
        TrieNode node = root;
        StringBuilder prefix = new StringBuilder();
        for (char ch : word.toCharArray()) {
            prefix.append(ch);
            node = node.children.get(ch);
            if (node.frequency == 1) break;
        }
        return prefix.toString();
    }
}