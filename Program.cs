using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cybersecurity_Awareness_Chatbot
{//start namespace
    // part 1
    public  class Program
    {//start class
        static void Main(string[] args)
        {// start main

            //  creating the  greeting voice instance
            //it will welcome the user 
            new voice_greeting() { };

            //creating the logo instance
            // the logo for the chatbot
            new chat_logo() { };

            //creating the instance class for the greeting 
            //greeting and name 
            greetings greet = new greetings ();
            greet.welcome();
            greet.ask_name();


            // the chatbot
            //create an instance
            // make it return your name 
            string name = greet.GetUsername();
            chatbot chat = new chatbot();

            int choice;

            // MENU LOOP (DO WHILE )
            do
            {
               
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n================================== MENU ==================================");
                Console.WriteLine("1. Ask Cybersecurity Questions");
                Console.WriteLine("2. About SecureBot");
                Console.WriteLine("3. Help");
                Console.WriteLine("4. Exit");
                Console.WriteLine("=============================================================================");
                Console.ResetColor();

                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = 0;
                }

                Console.WriteLine();

                if (choice == 1)
                {
                    chat.ai_chat(name);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                else if (choice == 2)
                {
                    showAbout(name);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                else if (choice == 3)
                {
                    showHelp();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nPress Enter to return to menu...");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                else if (choice == 4)

                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("SecureBot: Goodbye " + name + "! Stay safe online ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please select 1–4.");
                }

            } while (choice != 4);
        }

        // ABOUT SECTION
        static void showAbout(string name)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================== ABOUT SECUREBOT ==============================");
            Console.ResetColor();
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("I am SecureBot, your cybersecurity assistant.");
            Console.WriteLine("I help you understand online safety concepts.");
        }

        // HELP SECTION
        static void showHelp()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================== HELP ========================================");
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("- Password safety");
            Console.WriteLine("- Phishing attacks");
            Console.WriteLine("- Safe browsing");
            Console.WriteLine("- Cybersecurity tips");
            Console.ResetColor();
            Console.WriteLine("You can ask questions about cybersecurity topics:");
            Console.WriteLine("\nType 'exit' inside chat to return to menu.");
        
    
        }//end main 
    }//end class
}//end namespace
