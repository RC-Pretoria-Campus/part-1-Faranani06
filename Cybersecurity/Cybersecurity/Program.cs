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
    //Method to provide responses to user questions
    static string GetResponse(string question)
    {
        switch (question)
        {
            case "how are you?":
                return "I'm just a bot, but thanks for asking! How can i assist you";
            case "what's your purpose?":
                return "Is to help you understand and practice safe online behavior to protect agaiinst threats.";
            case "what can i ask you about?":
                return "You can ask me about anything like password safety, phishing, and safe browsing.";
            case "How can i ensure my password safety?":
                return "Use strong passwords with a mix of letters, numbers, and symbols. Avoid reusing passwords.";
            case "What is phishing?":
                return "Phishing is a scam to steal personal information by pretending to be a trusted source.";
            case "How can i browse the internet safely?":
                return "Always use HTTPS websites and avoid downloading unknown files.";
            default:
                return "I didn't quite understand that. Could you please rephrase?";
        }
    }
}
