using System;
using System.Media;
using System.Threading;

class CyberSecurityChatBot
{
    static void Main()
    {
        // Play Voice Greeting
        PlayVoiceGreeting();
        
        // Display ASCII Art Logo
        DisplayAsciiLogo();

        // Start Chatbot
        StartChat();
    }

    static void PlayVoiceGreeting()
    {
        try
        {
            using (SoundPlayer player = new SoundPlayer(@"C:\voicebot\WhatsApp Audio 2025-04-01 at 17.55.28.wav"))
            {
                player.PlaySync();  // Play the voice message
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Error playing greeting: " + ex.Message);
            Console.ResetColor();
        }
    }

    static void DisplayAsciiLogo()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine(@" _        __                         _                
|_) _    /   _    _|_ o  _     _    / \__  |  o __  _ 
|_)(/_   \__(_||_| |_ | (_)|_|_>    \_/| | |  | | |(/_                                                                                                                                       
     Cybersecurity Awareness Chatbot 
        ");
        Console.ResetColor();
    }

    static void StartChat()
    {
        Console.Write("\nEnter your name: ");
        string userName = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(userName))
        {
            userName = "User";
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"\nHello {userName}! I'm here to help you stay safe online.\n");
        Console.ResetColor();

        // Start conversation loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nAsk me a cybersecurity question: ");
            Console.ResetColor();

            string userInput = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops! It seems you entered nothing. Please ask a question.");
                Console.ResetColor();
                continue;
            }

            if (userInput == "exit" || userInput == "quit")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Goodbye! Stay safe online.");
                Console.ResetColor();
                break;
            }

            RespondToUser(userInput);
        }
    }

    static void RespondToUser(string input)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;

        // Normalize input to lowercase and remove leading/trailing whitespace
        input = input.Trim().ToLower();

        // Keyword-based approach
        if (input.Contains("how") && input.Contains("are") && input.Contains("you"))
        {
            Console.WriteLine("Even though I'm a bot, I'm operating at my best! I appreciate you asking.");
        }
        else if (input.Contains("purpose") && input.Contains("your"))
        {
            Console.WriteLine("My purpose is to educate you about cybersecurity and help you stay safe online.");
        }
        else if (input.Contains("ask") && input.Contains("about"))
        {
            Console.WriteLine("You can ask me about anything, password safety, phishing, and safe browsing.");
        }
        else if (input.Contains("password") && input.Contains("safety"))
        {
            Console.WriteLine("Use strong, unique passwords for each account. Consider using a password manager.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is a scam in which scammers manipulate you into giving private information. Watch out for risky websites and emails.");
        }
        else if (input.Contains("browse") && input.Contains("safely"))
        {
            Console.WriteLine("Avoid clicking on suspicious links, utilize HTTPS websites, and keep your software updated.");
        }
        else
        {
            Console.WriteLine("I didn't quite understand that. Could you rephrase? Here are some things you can ask me about:");
            Console.WriteLine("- How are you?");
            Console.WriteLine("- What's your purpose?");
            Console.WriteLine("- What can I ask you about?");
            Console.WriteLine("- Tell me about password safety.");
            Console.WriteLine("- What is phishing?");
            Console.WriteLine("- How do I browse safely?");
        }
    
    Console.ResetColor();
    }
}
