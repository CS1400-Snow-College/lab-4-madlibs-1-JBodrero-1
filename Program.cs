﻿//  Jonathan Bodrero
// June 21-23, 2025
//  Lab 5  Madlibs-1

Console.Clear();
//  Greeting / Instructions
Console.WriteLine("This is Mad Libs. I will ask you for a variety of words of different types.");
Console.WriteLine("When you are done providing the requested words I will build them \ninto a funny story for you. \nPlease enter the requested word types");

//  Original story for MadLib
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”).  When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”). Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";

string[] storyWords = originalStory.Split(' '); // This should hopefully split original story into words
string newStory = "";
string promptWords = "";
string wordInput;
bool containsOpenP;     //  Boolean to check for open parenthesis, (
bool containsCloseP;    //  Boolean to check for close parenthesis, )
string tempWord = "";

//foreach (string word in storyWords)
//{ Console.Write(word + " "); }  //  It chops story up into words.
//Console.WriteLine("\n");
for (int i = 0; i < storyWords.Length; i++)
{
    tempWord = storyWords[i];
    containsOpenP = tempWord.Contains('(');
    if (!containsOpenP)
    {
        newStory = newStory + " " + tempWord;  //  Add base word to story.
    }
    else if (containsOpenP)  // Has open parenthesis so need to create prompt word(s)
    {
        containsCloseP = tempWord.Contains(')');
        if (containsCloseP)     // If single-word prompt
        {   
            promptWords = tempWord.Replace("(", "").Replace(")", "");   // Trim ()
            //  Check for a vs an
            if ((char)promptWords[0] == (char)'a' || (char)promptWords[0] == (char)'e' || (char)promptWords[0] == (char)'i' || (char)promptWords[0] == (char)'o' || (char)promptWords[0] == (char)'u')
            { Console.Write($"Please give me an {promptWords}:  "); }
            else
            { Console.Write($"Please give me a {promptWords}:  "); }
            wordInput = Console.ReadLine();
            newStory = newStory + " " + wordInput;
        }
        else
        {

            promptWords = tempWord;
            do
            {
                i++;
                tempWord = storyWords[i];
                containsCloseP = tempWord.Contains(')');
                if (containsCloseP)     // If single-word prompt
                {   
                    promptWords = (promptWords + " " + tempWord).Replace("(", "").Replace(")", "");  // Trim ()
                //  Check for a vs an
                    if ((char)promptWords[0] == (char)'a' || (char)promptWords[0] == (char)'e' || (char)promptWords[0] == (char)'i' || (char)promptWords[0] == (char)'o' || (char)promptWords[0] == (char)'u')
                    { Console.Write($"Please give me an {promptWords}:  "); }
                    else
                    { Console.Write($"Please give me a {promptWords}:  "); }
                    wordInput = Console.ReadLine();
                    newStory = newStory + " " + wordInput;

                }
                else
                {
                    promptWords = promptWords + " " + tempWord;

                }       
            }
            while (containsCloseP == false);
        }
    }
}

Console.WriteLine("\n" + newStory);
