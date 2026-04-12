using System;
using System.Media;

namespace Cybersecurity_Awareness_Chatbot
{//start namespace 
    public class voice_greeting
    {// start class
        //the auto path
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public voice_greeting()
        {// start constructor
         // calling the greeting voice method 
            Greeting_Voice();
        
        }//end constructor 
        //method for  greeting voice the user 

        private void Greeting_Voice()
        {
            try
            {

                //start of the greeting_voice method 
                // geting the full path relace of Debug\bin\
                string fullpath = path.Replace(@"bin\Debug\", "");

                //playing the sound 
                string joined_path = fullpath + "C.A.C_greet.wav";
                // creatiing an instance for the sound player class
                SoundPlayer play_voice = new SoundPlayer(joined_path);
                //loading the audio
                play_voice.Load();
                //play till the end 
                play_voice.Play();
            }
            catch
            {
                Console.WriteLine("Voice greeting could not be played.");
            }

        }
    }//end class
}//end namespace 