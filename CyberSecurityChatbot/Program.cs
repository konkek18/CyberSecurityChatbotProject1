using CyberSecurityChatbot;
using System;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer audio = new AudioPlayer();
        audio.PlayGreeting();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"

   ______             __                           ____           __ 
  / ____/   __  __   / /_   ___    _____          / __ )  ____   / /_
 / /       / / / /  / __ \ / _ \  / ___/         / __  | / __ \ / __/
/ /___    / /_/ /  / /_/ //  __/ / /            / /_/ / / /_/ // /_  
\____/    \__, /  /_.___/ \___/ /_/            /_____/  \____/ \__/  
         /____/                                                      
");
        Console.WriteLine("=== CYBERSECURITY AWARENESS BOT ===");
        Console. ResetColor();

        Console.Write("Enter your name:");
        User user = new User ();
        user.Name = Console.ReadLine();

        Console.WriteLine($"Hello {user.Name}!");

        Chatbot chatbot = new Chatbot ();

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please enter something.");
                continue;
            }

            if (input.ToLower()  == "exit")
            {
                Console.WriteLine("Bot: Goodbye!");
                break;
            }

            Console.WriteLine("Bot: " + chatbot.GetResponse(input));    
        }
    }
}