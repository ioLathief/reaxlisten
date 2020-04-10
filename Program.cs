using System;
// using System.Drawing.Printing;
// using System.Linq;
// using reaxlisten.speech;

// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using System.Windows.Forms;
// using reaxlisten.speech;

namespace reaxlisten
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_ui());

            // foreach (var voicesName in Speech.GetVoicesNames())
            // {
            //     Console.Out.WriteLine(voicesName);
            // }
            // Speech.SetSynthVoice(Speech.GetVoicesNames()[1]);
            // Speech.Rate(50);
            // Speech.Speak("sadfas");            
            // Speech.Save("hello there i'm cool","some.mp3"); 


        }
    }
}
