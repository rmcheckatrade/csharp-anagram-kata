namespace Anagram;

/**
 |                                   Method |                       Mean |      Error |     StdDev |     Gen0 | Allocated |
 |----------------------------------------- |---------------------------:|-----------:|-----------:|---------:|----------:|
 |                             ShortAnagram |    29.387 μs (0.029387 ms) |  0.1866 μs |  0.1558 μs |  15.2893 |   96000 B |
 |                          ShortNonAnagram |    35.718 μs (0.035718 ms) |  0.5910 μs |  0.5528 μs |  15.2588 |   96000 B |
 |                                ShortSame | 1,101.329 μs (1.101329 ms) | 21.3664 μs | 23.7487 μs | 123.0469 |  784002 B |
 |                              LongAnagram |   916.627 μs (0.916627 ms) | 10.1650 μs |  8.4882 μs | 124.0234 |  784001 B |
 |                           LongNonAnagram | 1,083.418 μs (1.083418 ms) |  7.4261 μs |  6.9464 μs | 123.0469 |  784002 B |
 |         LongNonAnagramOfDifferingLengths |     1.264 μs (0.001264 ms) |  0.0058 μs |  0.0052 μs |        - |         - |
 | LongNonAnagramWhereFirsLetterDoesntExist | 1,153.321 μs (1.153321 ms) |  2.7911 μs |  2.6108 μs |  60.5469 |  388002 B |
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
