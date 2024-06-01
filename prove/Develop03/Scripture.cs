using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference Reference;
    private List<Word> Words;
    private Random random = new Random();   //  This is important to declare in order to use the random methods

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWords()
    {
        int wordsToHide = Math.Min(3, Words.Count(w => !w.IsHidden));   // Uses a minimum calculator to calculate the minimum of 3 and the remaining amount of unhidden words. The unhidden words amount is calulated in the shortcut lambda function, which is shorter than writing out an if-else statmenet.

        for (int i = 0; i < wordsToHide; i++)   // wordsToHide ensures that we only hide 3 or less words at a time.
        {
            int index;
            do
            {
                index = random.Next(Words.Count);
            } while (Words[index].IsHidden);    // This will force the loop to continue while it only finds hidden words and exit the do-while loop only once it finds an instance of a class where IsHidden = false.

            Words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);    // Returns a true or false depending on if all instances of the class have true or not for IsHidden.
    }
}
