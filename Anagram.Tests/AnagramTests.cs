using FluentAssertions;

namespace Anagram.Tests;

[Collection("Sequential")]
public class AnagramTests
{
    private readonly AnagramFinder _finder = new();

    [Theory]
    [InlineData(true, "a", "a")]
    [InlineData(true, "racecar", "racecar")]
    [InlineData(true, "doctorwho", "torchwood")]
    [InlineData(false, "a", "b")]
    [InlineData(false, "a", "aa")]
    [InlineData(false, "abb", "aab")]
    public void Tests(bool expected, string word1, string word2)
        => _finder.IsAnagram(word1, word2).Should().Be(expected);
}