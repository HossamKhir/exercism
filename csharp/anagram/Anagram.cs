using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    // public string baseWord { get; set; }
    private readonly string baseWord;
    private readonly string orderedBaseWord;

    // private Dictionary<char, int> mapCharCount;

    public Anagram(string baseWord)
    {
        // throw new NotImplementedException("You need to implement this function.");
        this.baseWord = baseWord.ToLower();
        this.orderedBaseWord = string.Concat(baseWord.OrderBy(c => c));
        // this.mapCharCount = this.baseWord.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }

    private bool isAnagram(string word) =>
        (word == this.baseWord)
            ? false
            : (string.Concat(word.OrderBy(c => c)) == this.orderedBaseWord);

    public string[] FindAnagrams(string[] potentialMatches) =>
        potentialMatches.Where(match => isAnagram(match.ToLower())).ToArray();
    // {
    //     // throw new NotImplementedException("You need to implement this function.");
    //     List<string> res = new List<string>();
    //     foreach (var match in potentialMatches)
    //     {
    //         if (match.ToLower() == this.baseWord)
    //             continue;
    //         if (match.Length != this.baseWord.Length)
    //             continue;
    //         var charCount = match
    //             .ToLower()
    //             .GroupBy(c => c)
    //             .ToDictionary(g => g.Key, g => g.Count());
    //         if (
    //             this.mapCharCount.Count != charCount.Count
    //             || this.mapCharCount.Except(charCount).Any()
    //         )
    //             continue;
    //         if (res.Count(r => r.ToLower() == match.ToLower()) != 0)
    //             continue;
    //         res.Add(match);
    //     }
    //     return res.ToArray();
    // }
}
