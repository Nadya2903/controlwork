Array ShowArray(string[] words)
{
    Console.Write("[");
    
    for (int i = 0; i < words.Length; i++)
        {
            if (i == words.Length - 1)
                Console.Write("'" + words[i] + "'] ");
            else
                Console.Write("'" + words[i] + "' ");
        }

    Console.Write("=> ");

    return words;
}


void ShortArray(string[] words)
{
    int countWords = 0;
    int countNewWords = 0;
    string[] newWords = new string[words.Length];

    Console.Write("[");
    
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < words[i].Length; j++)
            countWords++;

        if (countWords <= 3)
        {
            newWords[countNewWords] = words[i];
                
            if (i == words.Length - 1)
                Console.Write("'" + newWords[countNewWords] + "']");
            else
                Console.Write("'" + newWords[countNewWords] + "' ");

            countNewWords++;
        }
        
        countWords = 0;
    }

    if (countNewWords == 0)
        Console.Write("]");
}

string[] words = {"hello", "2", "world", ":-)"};

ShowArray(words);

ShortArray(words);