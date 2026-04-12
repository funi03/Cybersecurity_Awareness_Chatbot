using System;
using System.Drawing;

namespace Cybersecurity_Awareness_Chatbot
{//start namespace
    public  class chat_logo
    {//start class
        public chat_logo()
        {//start constructor 
            logo();
        }//end  constructor
        //logo method 

        private void logo()
        {//start the method 

            try
            {

                //path of the logo 
                string path = string.Empty;

                //auto get the full path
                string fullpath = AppDomain.CurrentDomain.BaseDirectory;
                //combining the path
                path = fullpath.Replace(@"bin\Debug\", "logo.jpeg");

                Bitmap image = new Bitmap(path);

                //Resizing for better console fit
                int width = 70;
                int height = 35;
                Bitmap resized = new Bitmap(image, new Size(width, height));

                //Default color , you can set yours before this line 

                string LogoChars = "@#S%?*+;:,. ";
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                //starting by the height
                for (int y = 0; y < resized.Height; y++)
                {
                    //then width
                    for (int x = 0; x < resized.Width; x++)
                    {
                        //color the pixel on x and y
                        Color pixel = resized.GetPixel(x, y);

                        //convert to grayscale
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;

                        //map grayscale  
                        int index = (gray * (LogoChars.Length - 1)) / 255;

                        Console.Write(LogoChars[index]);
                    }

                    Console.WriteLine();

                }
                Console.ResetColor();
            }
            catch
            {
                Console.WriteLine("Logo could not be displayed.");
            }

        }// end the method 
    }//end class
}//end namespace