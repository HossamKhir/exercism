using System;
using System.Collections.Generic;
using System.Linq;

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
        // INFO: LINQ approach 1
        return strand
        .Select((_, i) => i)
        .Where(i => i % 3 == 0)
        .Select(i => MAP[strand.Substring(i, 3)])
        .TakeWhile(protein => protein != "STOP")
        .ToArray();
        // List<string> result = new List<string>();
        // for (int i = 0; i < strand.Length; i += 3)
        // {
        //     var codon = strand.Substring(i, 3);
        //     // var protein = MAP[codon];
        //     var protein = ToProtein(codon);
        //     if (protein == "STOP")
        //     {
        //         return result.ToArray();
        //     }
        //     else
        //     {
        //         result.Add(protein);
        //     }
        // }
        // return result.ToArray();
    }

    // INFO: switch approach
    // public static string ToProtein(string codon) => codon switch
    // {
    //     "AUG" => "Methionine",
    //     "UUU" => "Phenylalanine",
    //     "UUC" => "Phenylalanine",
    //     "UUA" => "Leucine",
    //     "UUG" => "Leucine",
    //     "UCU" => "Serine",
    //     "UCC" => "Serine",
    //     "UCA" => "Serine",
    //     "UCG" => "Serine",
    //     "UAU" => "Tyrosine",
    //     "UAC" => "Tyrosine",
    //     "UGU" => "Cysteine",
    //     "UGC" => "Cysteine",
    //     "UGG" => "Tryptophan",
    //     "UAA" => "STOP",
    //     "UAG" => "STOP",
    //     "UGA" => "STOP",
    //     _ => throw new Exception("Invalid sequence")
    // };
}