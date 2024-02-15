using System;

class Program
{
    static void Main()
    {
        // Example with string
        string sentence = "This is an example sentence.";
        string searchWord = "example";

        bool containsExample = sentence.Contains(searchWord, StringComparison.OrdinalIgnoreCase);//El StringComparison.OrdinalIgnoreCaseEl parámetro se utiliza para una comparación que no distingue entre mayúsculas y minúsculas.

        if (containsExample)
        {
            Console.WriteLine($"The sentence contains the word '{searchWord}'.");
        }
        else
        {
            Console.WriteLine($"The sentence does not contain the word '{searchWord}'.");
        }
    }
}

