//  Jonathan Bodrero
// June 21-23, 2025
//  Lab 5  Madlibs-1

Console.Clear();
//  Greeting / Instructions
Console.WriteLine("This is Mad Libs. I will ask you for a variety of words of different types.");
Console.WriteLine("When you are done providing the requested words I will build them \ninto a funny story for you. \nPlease enter the requested word types");

//  Original story for MadLib
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). "; //When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural noun) to pay for the vacation.";

string[] storyWords = originalStory.Split(' '); // This should hopefully split original story into words
string newStory = "";
string promptWords = "";
string wordInput;
bool containsOpenP;     //  Boolean to check for open parenthesis, (
bool containsCloseP;    //  Boolean to check for close parenthesis, )



string tempWord = "";
//  Verify that it split into words
//for (int i = 0; i < 20; i++)
//{ Console.Write(storyWords[i] + " - "); }

foreach (string word in storyWords)
{ Console.Write(word + " "); }  //  It chops story up into words.
Console.WriteLine("\n");
for (int i = 0; i < storyWords.Length; i++)
{
    tempWord = storyWords[i];
    containsOpenP = tempWord.Contains('(');
    if (!containsOpenP)
    {
        newStory = newStory + " " + tempWord;
    }
    else
    {
        //do
        {
            tempWord = storyWords[i];
            containsCloseP = tempWord.Contains(')');
            if (containsCloseP)     // If single-word prompt
            {
                promptWords = tempWord;
                Console.Write($"Please give me a/an {promptWords}:  ");
                wordInput = Console.ReadLine();
                newStory = newStory + " " + wordInput;

            }
            /*if (!containsCloseP)
            {
                promptWords = tempWord;
                i++;
                tempWord = storyWords[i++];
                Console.Write($"Please give me a/an {tempWord}:  ");
                wordInput = Console.ReadLine();
                newStory = " " + wordInput;
                }

        }
        while (containsCloseP == false);*/
        }
    }
}

Console.WriteLine("\n" + newStory);
