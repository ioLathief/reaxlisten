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
            GlobalHotkey.Run();
        }
   

        private void play_pause_btn_Click(object sender, EventArgs e)
        {
            if (Speech.GetStatus() == status.Playing)
            {
                Speech.Pause();
                return;
            }

            if (Speech.GetStatus() == status.Paused)
            {
                Speech.Resume();
                return;
            }
            
            if (speech_txt_box.Text == "")
            {
                status_label.Text = "Enter some text to play";
                return;
            }
            Speech.PlayAsync(speech_txt_box.Text);
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (Speech.GetStatus() == status.Playing || Speech.GetStatus() == status.Paused)
            {
                Speech.Stop();
            }
        }

        private void paste_btn_Click(object sender, EventArgs e)
        {
            speech_txt_box.Text = Utils.GetClipboardText();
        }

        private void pref_btn_Click(object sender, EventArgs e)
        {
            configure_ui config = new configure_ui();
            config.ShowDialog();
        }
    }
}