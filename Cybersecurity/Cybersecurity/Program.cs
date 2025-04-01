using System;
using System.IO;
using System.Speech.Synthesis;

class CybersecurityChatbot
{
    static void Main()
    {
        //Initializing the speech synthesizer for text-to-speech output
        SpeechSynthesizer synth = new SpeechSynthesizer
        {
            Volume = 100,   //setting the speech to max
            Rate = 0   //Collecting the speech rate to normal speed
        };

        //Displaying the chatbot's ASCII art logo
        DisplayAsciiArt();

        //Greeting the user
        synth.Speak("Hello!  Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.");

        //Printing the chatbot's welcome message
        Console.WriteLine("********************************************");
        Console.WriteLine("Welcome to the Cybersecurity Awareness Bot");
        Console.WriteLine("*******************************************\n");

        //Prompting the user to enter their name
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        synth.Speak($"Nice to meet you, {userName}!");

        //Starting the main chatbot interaction loop
        RunChatbot(synth, userName);
    }
    //Method to display the ASCII art logo
    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
         ██████╗██╗  ██╗ █████╗ ████████╗    ██████╗  ██████╗ ████████╗
        ██╔════╝██║  ██║██╔══██╗╚══██╔══╝    ██╔══██╗██╔═══██╗╚══██╔══╝
        ██║     ███████║███████║   ██║       ██████╔╝██║   ██║   ██║   
        ██║     ██╔══██║██╔══██║   ██║       ██╔═══╝ ██║   ██║   ██║   
        ╚██████╗██║  ██║██║  ██║   ██║       ██║     ╚██████╔╝   ██║   
         ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═╝      ╚═════╝    ╚═╝   
                   Cybersecurity Awareness Bot
        ");
        Console.ResetColor();
    }

    //Main loop for interacting with the user
    static void RunChatbot(SpeechSynthesizer synth, string userName)
    {
        while (true)
        {
            //Prompting the user to ask a question or exit
            Console.Write($"\n{userName}, ask a question or type 'exit' to quit: ");
            string question = Console.ReadLine().ToLower();

            //A loop that shows exit if the user types exit
            if (question == "exit")
            {
                synth.Speak($"Goodbye, {userName}! Stay safe online.");
                Console.WriteLine($"Goodbye, {userName}! Stay safe online.");
                break;
            }

            string response = GetResponse(question);
            synth.Speak(response);

            //Displaying the response in yellow text
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(response);
            Console.ResetColor();
        }
    }
}
