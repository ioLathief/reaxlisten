﻿using System.ComponentModel;

namespace reaxlisten
{
    partial class configure_ui
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
            this.title_lbl1 = new System.Windows.Forms.Label();
            this.title_lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voices_combo = new System.Windows.Forms.ComboBox();
            this.volume_trackbar = new System.Windows.Forms.TrackBar();
            this.rate_trackbar = new System.Windows.Forms.TrackBar();
            this.save_btn = new System.Windows.Forms.Button();
            this.hk_pause_2_combo = new System.Windows.Forms.ComboBox();
            this.hk_stop_3_combo = new System.Windows.Forms.ComboBox();
            this.hk_playres_1_combo = new System.Windows.Forms.ComboBox();
            this.hk_playres_2_combo = new System.Windows.Forms.ComboBox();
            this.hk_playres_3_combo = new System.Windows.Forms.ComboBox();
            this.hk_pause_1_combo = new System.Windows.Forms.ComboBox();
            this.hk_pause_3_combo = new System.Windows.Forms.ComboBox();
            this.hk_stop_2_combo = new System.Windows.Forms.ComboBox();
            this.hk_stop_1_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.volume_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.rate_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl1
            // 
            this.title_lbl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.title_lbl1.Location = new System.Drawing.Point(36, 28);
            this.title_lbl1.Name = "title_lbl1";
            this.title_lbl1.Size = new System.Drawing.Size(132, 23);
            this.title_lbl1.TabIndex = 0;
            this.title_lbl1.Text = "Speech Configuration";
            // 
            // title_lbl2
            // 
            this.title_lbl2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.title_lbl2.Location = new System.Drawing.Point(36, 228);
            this.title_lbl2.Name = "title_lbl2";
            this.title_lbl2.Size = new System.Drawing.Size(132, 23);
            this.title_lbl2.TabIndex = 1;
            this.title_lbl2.Text = "Hot Key Configuration";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voice";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Play/Resume";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stop";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Pause";
            // 
            // voices_combo
            // 
            this.voices_combo.FormattingEnabled = true;
            this.voices_combo.Location = new System.Drawing.Point(197, 65);
            this.voices_combo.Name = "voices_combo";
            this.voices_combo.Size = new System.Drawing.Size(201, 23);
            this.voices_combo.TabIndex = 8;
            // 
            // volume_trackbar
            // 
            this.volume_trackbar.Location = new System.Drawing.Point(197, 105);
            this.volume_trackbar.Maximum = 100;
            this.volume_trackbar.Name = "volume_trackbar";
            this.volume_trackbar.Size = new System.Drawing.Size(201, 45);
            this.volume_trackbar.TabIndex = 9;
            // 
            // rate_trackbar
            // 
            this.rate_trackbar.Location = new System.Drawing.Point(197, 156);
            this.rate_trackbar.Maximum = 100;
            this.rate_trackbar.Name = "rate_trackbar";
            this.rate_trackbar.Size = new System.Drawing.Size(201, 45);
            this.rate_trackbar.TabIndex = 10;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(323, 432);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // hk_pause_2_combo
            // 
            this.hk_pause_2_combo.FormattingEnabled = true;
            this.hk_pause_2_combo.Location = new System.Drawing.Point(258, 312);
            this.hk_pause_2_combo.Name = "hk_pause_2_combo";
            this.hk_pause_2_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_pause_2_combo.TabIndex = 15;
            // 
            // hk_stop_3_combo
            // 
            this.hk_stop_3_combo.FormattingEnabled = true;
            this.hk_stop_3_combo.Location = new System.Drawing.Point(400, 348);
            this.hk_stop_3_combo.Name = "hk_stop_3_combo";
            this.hk_stop_3_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_stop_3_combo.TabIndex = 16;
            // 
            // hk_playres_1_combo
            // 
            this.hk_playres_1_combo.FormattingEnabled = true;
            this.hk_playres_1_combo.Location = new System.Drawing.Point(119, 269);
            this.hk_playres_1_combo.Name = "hk_playres_1_combo";
            this.hk_playres_1_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_playres_1_combo.TabIndex = 17;
            // 
            // hk_playres_2_combo
            // 
            this.hk_playres_2_combo.FormattingEnabled = true;
            this.hk_playres_2_combo.Location = new System.Drawing.Point(258, 269);
            this.hk_playres_2_combo.Name = "hk_playres_2_combo";
            this.hk_playres_2_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_playres_2_combo.TabIndex = 18;
            // 
            // hk_playres_3_combo
            // 
            this.hk_playres_3_combo.FormattingEnabled = true;
            this.hk_playres_3_combo.Location = new System.Drawing.Point(400, 269);
            this.hk_playres_3_combo.Name = "hk_playres_3_combo";
            this.hk_playres_3_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_playres_3_combo.TabIndex = 19;
            // 
            // hk_pause_1_combo
            // 
            this.hk_pause_1_combo.FormattingEnabled = true;
            this.hk_pause_1_combo.Location = new System.Drawing.Point(119, 312);
            this.hk_pause_1_combo.Name = "hk_pause_1_combo";
            this.hk_pause_1_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_pause_1_combo.TabIndex = 20;
            // 
            // hk_pause_3_combo
            // 
            this.hk_pause_3_combo.FormattingEnabled = true;
            this.hk_pause_3_combo.Location = new System.Drawing.Point(400, 312);
            this.hk_pause_3_combo.Name = "hk_pause_3_combo";
            this.hk_pause_3_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_pause_3_combo.TabIndex = 21;
            // 
            // hk_stop_2_combo
            // 
            this.hk_stop_2_combo.FormattingEnabled = true;
            this.hk_stop_2_combo.Location = new System.Drawing.Point(258, 348);
            this.hk_stop_2_combo.Name = "hk_stop_2_combo";
            this.hk_stop_2_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_stop_2_combo.TabIndex = 22;
            // 
            // hk_stop_1_combo
            // 
            this.hk_stop_1_combo.FormattingEnabled = true;
            this.hk_stop_1_combo.Location = new System.Drawing.Point(119, 348);
            this.hk_stop_1_combo.Name = "hk_stop_1_combo";
            this.hk_stop_1_combo.Size = new System.Drawing.Size(121, 23);
            this.hk_stop_1_combo.TabIndex = 23;
            // 
            // configure_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 489);
            this.Controls.Add(this.hk_stop_1_combo);
            this.Controls.Add(this.hk_stop_2_combo);
            this.Controls.Add(this.hk_pause_3_combo);
            this.Controls.Add(this.hk_pause_1_combo);
            this.Controls.Add(this.hk_playres_3_combo);
            this.Controls.Add(this.hk_playres_2_combo);
            this.Controls.Add(this.hk_playres_1_combo);
            this.Controls.Add(this.hk_stop_3_combo);
            this.Controls.Add(this.hk_pause_2_combo);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.rate_trackbar);
            this.Controls.Add(this.volume_trackbar);
            this.Controls.Add(this.voices_combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_lbl2);
            this.Controls.Add(this.title_lbl1);
            this.Name = "configure_ui";
            this.Text = "configure_ui";
            ((System.ComponentModel.ISupportInitialize) (this.volume_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.rate_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label title_lbl1;
        private System.Windows.Forms.Label title_lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox voices_combo;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TrackBar rate_trackbar;
        private System.Windows.Forms.TrackBar volume_trackbar;
        private System.Windows.Forms.ComboBox hk_stop_1_combo;
        private System.Windows.Forms.ComboBox hk_stop_2_combo;
        private System.Windows.Forms.ComboBox hk_pause_3_combo;
        private System.Windows.Forms.ComboBox hk_pause_1_combo;
        private System.Windows.Forms.ComboBox hk_playres_3_combo;
        private System.Windows.Forms.ComboBox hk_playres_2_combo;
        private System.Windows.Forms.ComboBox hk_playres_1_combo;
        private System.Windows.Forms.ComboBox hk_stop_3_combo;
        private System.Windows.Forms.ComboBox hk_pause_2_combo;
    }
}