public class Solution {
    public int PrefixCount(string[] words, string pref) {
        Trie trie = new Trie();
        foreach (string word in words)
        {
            trie.Insert(word);
        }
        return trie.CountWordsWithPrefix(pref);
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public int WordCount = 0;  // Marks the end of a word
}

public class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (char ch in word)
        {
            if (!node.Children.ContainsKey(ch))
            {
                node.Children[ch] = new TrieNode();
            }
            node = node.Children[ch];
        }
        node.WordCount++;
    }

    public int CountWordsWithPrefix(string prefix)
    {
        TrieNode node = root;
        foreach (char ch in prefix)
        {
            if (!node.Children.ContainsKey(ch))
            {
                return 0;  // Prefix not found
            }
            node = node.Children[ch];
        }
        return CountWords(node);
    }

    private int CountWords(TrieNode node)
    {
        int count = node.WordCount;
        foreach (var child in node.Children.Values)
        {
            count += CountWords(child);
        }
        return count;
    }
}