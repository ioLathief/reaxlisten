using System.ComponentModel;

namespace reaxlisten
{
    partial class main_ui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paste_btn = new System.Windows.Forms.Button();
            this.speech_txt_box = new System.Windows.Forms.RichTextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.play_pause_btn = new System.Windows.Forms.Button();
            this.pref_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paste_btn
            // 
            this.paste_btn.Location = new System.Drawing.Point(500, 255);
            this.paste_btn.Name = "paste_btn";
            this.paste_btn.Size = new System.Drawing.Size(73, 25);
            this.paste_btn.TabIndex = 0;
            this.paste_btn.Text = "Paste";
            this.paste_btn.UseVisualStyleBackColor = true;
            // 
            // speech_txt_box
            // 
            this.speech_txt_box.Location = new System.Drawing.Point(43, 29);
            this.speech_txt_box.Name = "speech_txt_box";
            this.speech_txt_box.Size = new System.Drawing.Size(531, 205);
            this.speech_txt_box.TabIndex = 1;
            this.speech_txt_box.Text = "";
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(42, 255);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(73, 25);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            // 
            // play_pause_btn
            // 
            this.play_pause_btn.Location = new System.Drawing.Point(142, 255);
            this.play_pause_btn.Name = "play_pause_btn";
            this.play_pause_btn.Size = new System.Drawing.Size(73, 25);
            this.play_pause_btn.TabIndex = 3;
            this.play_pause_btn.Text = "Play/Pause";
            this.play_pause_btn.UseVisualStyleBackColor = true;
            // 
            // pref_btn
            // 
            this.pref_btn.Location = new System.Drawing.Point(42, 308);
            this.pref_btn.Name = "pref_btn";
            this.pref_btn.Size = new System.Drawing.Size(73, 25);
            this.pref_btn.TabIndex = 4;
            this.pref_btn.Text = "Configure";
            this.pref_btn.UseVisualStyleBackColor = true;
            // 
            // main_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 389);
            this.Controls.Add(this.pref_btn);
            this.Controls.Add(this.play_pause_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.speech_txt_box);
            this.Controls.Add(this.paste_btn);
            this.Name = "main_ui";
            this.Text = "main";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button paste_btn;
        private System.Windows.Forms.RichTextBox speech_txt_box;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button play_pause_btn;
        private System.Windows.Forms.Button pref_btn;
    }
}