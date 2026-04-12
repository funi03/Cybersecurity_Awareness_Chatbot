using System;

namespace Cybersecurity_Awareness_Chatbot
{//start namespace
    public class greetings
    {//start class
     //global variable
        private string username = string.Empty;

        // welcoming the user 
        public void welcome()
        {//start the method
         //displaying the welcome 


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************************");
            Console.WriteLine("============================================================");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("         WELCOME TO SECUREBOT CYBER SAFETY ASSISTANT         ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("============================================================");
            Console.WriteLine("************************************************************");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine(" SecureBot is here to help you stay safe online.");
            Console.WriteLine(" Learn how to create strong passwords,");
            Console.WriteLine(" avoid phishing scams, and browse safely.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Your digital safety matters — let's protect it together.");
            //reset the color   
            Console.ResetColor();
            Console.WriteLine();


        }//end the method 
        // asking for the user name 
        public void ask_name()
        {//start the method 
            //display the AI chat message
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" SecureBot: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Please enter your name: ");
            // reset the color 
            Console.ResetColor();

            // using the do while
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" You: ");
                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();

                //reset color 
                Console.ResetColor();

            } while (!isEmpty());// end of the loo



        }// end the method 
        // the boolean method to check if ther user entered name 

        private Boolean isEmpty()
        {//start of the method

            {
                // check if empty
                if (username == "")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" SecureBot: ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Please enter your name.");
                    return false;
                }

                // check if name contains numbers
                foreach (char c in username)
                {
                    if (char.IsDigit(c))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" SecureBot: ");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Numbers are not allowed in your name, write name only.");
                        return false;
                    }
                }

                // if valid name
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" SecureBot: ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" Nice to meet you, " + username + "i hope you are good and safe!");

                return true;
            }
        }
    
        public string GetUsername()
        {// method
            return username;
        }// method

    }//end class
}//end namespace