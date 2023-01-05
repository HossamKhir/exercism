using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static Dictionary<string, string> MAP = new Dictionary<string, string>() {
        {"AUG", "Methionine"},
        {"UUU", "Phenylalanine"},
        {"UUC", "Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU", "Serine"},
        {"UCC", "Serine"},
        {"UCA", "Serine"},
        {"UCG", "Serine"},
        {"UAU", "Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU", "Cysteine"},
        {"UGC", "Cysteine"},
        {"UGG", "Tryptophan"},
        {"UAA", "STOP"},
        {"UAG", "STOP"},
        {"UGA", "STOP"},
    };
    public static string[] Proteins(string strand)
    {
        // throw new NotImplementedException();
        List<string> result = new List<string>();
        for (int i = 0; i < strand.Length; i += 3)
        {
            var codon = strand.Substring(i, 3);
            var protein = MAP[codon];
            if (protein == "STOP")
            {
                return result.ToArray();
            }
            else
            {
                result.Add(protein);
            }
        }
        return result.ToArray();
    }
}