using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace CS;
/*
# of words with 1 characters: 0
# of words with 2 characters: 96
# of words with 3 characters: 972
# of words with 4 characters: 3903
# of words with 5 characters: 8636
# of words with 6 characters: 15232
# of words with 7 characters: 23109
# of words with 8 characters: 28419
# of words with 9 characters: 24791
# of words with 10 characters: 20195
# of words with 11 characters: 15407
# of words with 12 characters: 11273
# of words with 13 characters: 7781
# of words with 14 characters: 5100
# of words with 15 characters: 3178
# of words with 16 characters: 0
# of words with 17 characters: 0
# of words with 18 characters: 0
# of words with 19 characters: 0
# of words with 20 characters: 0

The median word is CHASTISES.
 */
public class IO {
    public static void IOMain() {
        int cnt = 0;
        // The using statement ensure the StreamReader
        // is correctly disposed.
        using (StreamReader input = new StreamReader("words.txt")) {
            while (!input.EndOfStream) {
                string line = input.ReadLine();
                cnt++;
            }
        }

        // Number of words with certain character lengths
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine("# of words with " + i + " characters: " + NumWordsWithSpecificLength(ReadWordsList("words.txt"), i));
        }

        Console.WriteLine("median word " + MedianWord(ReadWordsList("words.txt")));


        List<string> words = new List<string>{"have","i","im","ive"};


    }

    public static List<string> ReadWordsList(string filename)
    {
        List<string> result = new List<string>();
        //int cnt = 0;
        using (StreamReader input = new StreamReader(filename))
        {
            while (!input.EndOfStream)
            {
                result.Add(input.ReadLine());
                //Console.WriteLine(result[cnt]);
                //cnt++;
            }
        }
        return result;
    }

    public static int NumWordsWithSpecificLength(List<string> words, int length)
    {
        int cnt = 0;
        // Fill this in
        int i = 0;
        for(i = 0; i < words.Count; i++)
        {
            if (words[i].Length == length) {
                cnt++;
            }
        }

        return cnt;
    }

    // Returns the median of a list of strings (the incoming list may be unsorted).
    // If there is an even number of words, there are two words “in the middle”,
    // use the smaller of the two as the result.
    public static string MedianWord(List<string> words)
    {
        // returns the median word
        string ret = "";

        List<String> sorted = words.OrderBy(str => str.Length).ToList();
        if (sorted.Count % 2 == 0)
        {
            ret = sorted[(sorted.Count / 2) - 1];
        } else
        {
            ret = sorted[(sorted.Count / 2)];
        }

        return ret;
    }
}