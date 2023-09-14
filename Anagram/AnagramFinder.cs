namespace Anagram;

/**
 * Results
 * Short Anagram: 0.1168 ms
 * Short non-anagram: 0.0707 ms
 * Short same: 4.7072 ms
 * Long anagram: 3.7222 ms
 * Long non-anagram: 4.7275 ms
 * Long non-anagram of differing lengths: 0.0038 ms
 * Long non-anagram where first letter doesn't exist: 5.703 ms
 */
public class AnagramFinder
{
    public bool IsAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        var lowerWord1 = word1.ToLower();
        var lowerWord2 = word2.ToLower();
        var map = new Dictionary<char, int>();

        foreach (var letter in lowerWord1)
        {
            if (map.ContainsKey(letter))
            {
                map[letter]++;
            }
            else
            {
                map[letter] = 1;
            }
        }

        foreach (var letter in lowerWord2)
        {
            if (!map.ContainsKey(letter) || map[letter] == 0)
            {
                return false;
            }

            map[letter]--;
        }

        return true;
    }
}