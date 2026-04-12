using System;
using System.Collections;

namespace Cybersecurity_Awareness_Chatbot
{//start  namespace
   public class chatbot
    {// start class
     // arrays
        ArrayList answers = new ArrayList();
        ArrayList ignoring = new ArrayList();

        public chatbot()
        {
            // constructor

            //adding answers

            Console.ForegroundColor = ConsoleColor.Magenta;
            answers.Add("i am doing great, thanks for asking");
            answers.Add("my purpose is to help you stay safe online");
          

            //  add answers 
            Console.ForegroundColor = ConsoleColor.Cyan;
            answers.Add("password security: use at least 8 characters for strong password strength");
            answers.Add("password complexity: include uppercase, lowercase, numbers, and special symbols");
            answers.Add("password hygiene: never reuse passwords across multiple accounts");
            answers.Add("phishing attack: attackers trick users into revealing sensitive information");
            answers.Add("software updates: keep systems patched to fix security vulnerabilities");
            answers.Add("antivirus protection: use anti-malware software to detect threats");
            answers.Add("public Wi-Fi risk: avoid sensitive actions on unsecured networks");
            answers.Add("data backup: regularly back up files to prevent data loss or ransomware damage");
            answers.Add("session security: always log out from shared or public devices");
            answers.Add("malware safety: avoid downloading files from unknown or untrusted sources");
            answers.Add("app permissions: review and limit access to protect privacy and data security");
            answers.Add("ransomware protection: keep backups and avoid suspicious downloads");
            answers.Add("firewall security: use firewalls to block unauthorized network access");
            answers.Add("authentication security: use strong login credentials and multi-factor authentication");
            answers.Add("identity theft prevention: protect personal information from being exposed online");
            answers.Add("cyber hygiene: practice safe online behavior to reduce cyber risks");
            // ignore words
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ignoring.Add("what");
            ignoring.Add("is");
            ignoring.Add("about");
            ignoring.Add("how");
            ignoring.Add("why");
            ignoring.Add("can");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("did");
            ignoring.Add("should");
            ignoring.Add("could");
            ignoring.Add("would");
        }

        public void ai_chat(string name)
        {
            string asking;
       
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nSecureBot: Hello " + name + "! Ask me about cybersecurity.");
            Console.WriteLine("SecureBot: Type 'exit' to stop.\n");

            // DO WHILE
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(name + ": ");
                asking = Console.ReadLine().ToLower();

            } while (end_chat(asking, name));
        }

        //  NOW ALSO RECEIVES NAME
        private Boolean end_chat(string question, string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (question == "")
            {
                Console.WriteLine("SecureBot: Returning to menu...");
                return false; // exits chatbot
            }

            if (question == "exit")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("SecureBot: Goodbye " + name + "!");
                return false;
            }

            bool found = false;

            string[] words = question.Split(' ');

            foreach (string word in words)
            {
                if (ignoring.Contains(word))
                    continue;

                foreach (string answer in answers)
                {
                    if (answer.Contains(word))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("SecureBot: " + name + ", " + answer);
                        found = true;
                        break;
                    }
                }

                if (found) break;
            }

            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SecureBot: I didn’t understand that, " + name + ".");
            }

            return true;
        
        }//end method
    }//end class
}// end namespace 