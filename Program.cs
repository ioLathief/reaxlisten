using System;
// using System.Speech.Synthesis;
// using System.Threading;
using System.Windows.Forms;
using System.Threading;


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
            
        }

        public static void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Console.WriteLine("asdfasd");
        }
        
    }
}
