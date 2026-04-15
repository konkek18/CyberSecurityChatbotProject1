

namespace CyberSecurityChatbot
{
    internal class Chatbot
    {
        public string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm just a bot, but I'm here to help you!";

            if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols.";

            if (input.Contains("phishing"))
                return "Phishing is a scam used to steal personal information.";

            if (input.Contains("purpose"))
                return "My purpose is to help you stay safe online.";

            return "I don't understand that. Try asking about cybersecurity.";
        }
    }
}
