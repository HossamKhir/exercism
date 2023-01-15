using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    public string BaseWord { get; set; }

    private Dictionary<char, int> mapCharCount;

    public Anagram(string baseWord)
    {
        // throw new NotImplementedException("You need to implement this function.");
        this.BaseWord = baseWord.ToLower();
        this.mapCharCount = this.BaseWord.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        // throw new NotImplementedException("You need to implement this function.");
        List<string> res = new List<string>();
        foreach (var match in potentialMatches)
        {
            if (match.ToLower() == this.BaseWord)
                continue;
            if (match.Length != this.BaseWord.Length)
                continue;
            var charCount = match
                .ToLower()
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            if (
                this.mapCharCount.Count != charCount.Count
                || this.mapCharCount.Except(charCount).Any()
            )
                continue;
            if (res.Count(r => r.ToLower() == match.ToLower()) != 0)
                continue;
            res.Add(match);
        }
        return res.ToArray();
    }
}
