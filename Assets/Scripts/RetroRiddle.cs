using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RetroRiddle : MonoBehaviour
{
    string introLine1 = "I hope you are the one wise enought to win the prize\n";
    string introLine2 = "You will be subjected to a set of riddles\n";
    string introLine3 = "Fail to answer all of them correctly and the prize is forever gone\n";
    string introLine4 = "Are you ready?\n";

    string riddle1 = "It cannot be seen, cannot be felt\n" +
                     "Cannot be heard, cannot be smelt\n" +
                     "It lies behind stars and under hills\n" +
                     "And empty holes it fills\n" +
                     "It comes out first and follows after\n" +
                     "Ends life, kills laughter";

    string riddle1Correct = "I see that you are a smart one\n"+
                            "The key for the next riddle is: 0000";
    string riddle1Wrong = "I am sorry but the game is over for you";

    string riddle2 = "Voiceless it cries\n" +
                     "Wingless flutters\n" +
                     "Toothless bites\n" +
                     "Mouthless mutters";

    string riddle2Correct = "You remind me of a smart little hobbit\n" +
                            "Next key: shire";
    string riddle2Wrong = "I get to keep the ring";

    string riddle3 = "What has roots as nobody sees\n" +
                     "Is taller than trees\n" +
                     "Up, up, up it goes\n" +
                     "And yet never grows";

    string riddle3Correct = "There you go, I knew it was you\n" +
                            "I've been waiting for someone worthy for so long\n" +
                            "The prize is yours, just type: 42";
    string riddle3Wrong = "Maybe in another life";

    int stage = 0;

    // Start is called before the first frame update
    void Start()
    {
        introText();
    }

    void introText()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(introLine1);
        Terminal.WriteLine(introLine2);
        Terminal.WriteLine(introLine3);
        Terminal.WriteLine(introLine4);
    }

    void OnUserInput(string input)
    {
        if (input.ToLower() == "restart")
        {
            stage = 0;
            introText();
        }
        else
            switch (stage)
            {
                case 0:
                    if (input.ToLower() == "yes")
                    {
                        FirstRiddle();
                    }
                    break;
                case 1:
                    if (input.ToLower() == "dark")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine(riddle1Correct);
                    }
                    else if (input == "0000")
                         { 
                         SecondRiddle();
                         }
                         else
                         {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(riddle1Wrong);
                         }
                    break;
                case 2:
                    if (input.ToLower() == "wind")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine(riddle2Correct);
                    }
                    else if (input == "shire")
                         {
                            ThirdRiddle();
                         }
                         else
                         {
                            Terminal.ClearScreen();
                            Terminal.WriteLine(riddle2Wrong);
                         }
                    break;
                case 3:
                    if (input.ToLower() == "mountain")
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine(riddle3Correct);
                    }
                    else if (input == "42")
                    {
                        ThePrize();
                    }
                    else
                    {
                        Terminal.ClearScreen();
                        Terminal.WriteLine(riddle3Wrong);
                    }
                    break;
                default: return;
            }
    }

    void FirstRiddle()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(riddle1);
        stage++;
    }

    void SecondRiddle()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(riddle2);
        stage++;
    }

    void ThirdRiddle()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(riddle3);
        stage++;
    }

    void ThePrize()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Ai o bere de la mine");
        stage++;
    }
}
