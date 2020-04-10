// using System;

using System;
using System.Windows.Forms;
using reaxlisten.speech;

namespace reaxlisten
{
    public partial class main_ui : Form
    {
        public main_ui()
        {
            InitializeComponent();
        }


        private void play_pause_btn_Click(object sender, EventArgs e)
        {
            if (Speech.GetStatus() == status.Playing)
            {
                
            }
            
            Speech.PlayAsync(speech_txt_box.Text);
            if (speech_txt_box.Text == "")
            {
                //todo: notify Enter text to speak
                Console.Out.WriteLine("todo: Enter text to speak");
            }
        }
    }
}