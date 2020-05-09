using System;
using System.Windows.Forms;
using reaxlisten.speech;

namespace reaxlisten
{
	public partial class configure_ui : Form
	{
		public configure_ui()
		{
			InitializeComponent();

			var setting = Data.GetSetting();
			
			//voice
			foreach (var voicesName in Speech.GetVoicesNames()) voices_combo.Items.Add(voicesName);
			voices_combo.SelectedIndex = setting.SelectedVoice;
			
			//volume
			volume_trackbar.Value = setting.Volume;
			
			//Rate
			rate_trackbar.Value = setting.Rate;
			
			//Play Resume key 1 HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_playres_1_combo.Items.Add(key.ToString());
			hk_playres_1_combo.SelectedIndex = (int) setting.PlayResume.Key1;
			
			//Play Resume key 2 HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_playres_2_combo.Items.Add(key.ToString());
			hk_playres_2_combo.SelectedIndex = (int) setting.PlayResume.Key2;
			
			//Play Resume key 3 HotKey
			foreach (var key in Enum.GetValues(typeof(AlphabeticKey))) hk_playres_3_combo.Items.Add(key.ToString());
			hk_playres_3_combo.SelectedIndex = (int) setting.PlayResume.Key3;
			
			//Pause key 1 HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_pause_1_combo.Items.Add(key.ToString());
			hk_pause_1_combo.SelectedIndex = (int) setting.Pause.Key1;
			
			//Pause key 2 HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_pause_2_combo.Items.Add(key.ToString());
			hk_pause_2_combo.SelectedIndex = (int) setting.Pause.Key2;
			
			//Pause key 3 HotKey
			foreach (var key in Enum.GetValues(typeof(AlphabeticKey))) hk_pause_3_combo.Items.Add(key.ToString());
			hk_pause_3_combo.SelectedIndex = (int) setting.Pause.Key3;
			
			//Stop key 1  HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_stop_1_combo.Items.Add(key.ToString());
			hk_stop_1_combo.SelectedIndex = (int) setting.Stop.Key1;
			
			//Stop key 2  HotKey
			foreach (var key in Enum.GetValues(typeof(ControlKey))) hk_stop_2_combo.Items.Add(key.ToString());
			hk_stop_2_combo.SelectedIndex = (int) setting.Stop.Key2;
			
			//Stop key 3  HotKey
			foreach (var key in Enum.GetValues(typeof(AlphabeticKey))) hk_stop_3_combo.Items.Add(key.ToString());
			hk_stop_3_combo.SelectedIndex = (int) setting.Stop.Key3;
		}

		private void save_btn_Click(object sender, EventArgs e)
		{
			var st = new Setting
			{
				SelectedVoice = voices_combo.SelectedIndex,
				Volume = volume_trackbar.Value,
				Rate = rate_trackbar.Value,
				PlayResume = new HotKey
				{
					Key1 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_playres_1_combo.SelectedIndex),
					Key2 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_playres_2_combo.SelectedIndex),
					Key3 = (AlphabeticKey)Enum.GetValues(typeof(AlphabeticKey)).GetValue(hk_playres_3_combo.SelectedIndex)
				},
				Pause = new HotKey
				{
					Key1 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_pause_1_combo.SelectedIndex),
					Key2 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_pause_2_combo.SelectedIndex),
					Key3 = (AlphabeticKey)Enum.GetValues(typeof(AlphabeticKey)).GetValue(hk_pause_3_combo.SelectedIndex)
				},
				Stop = new HotKey
				{
					Key1 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_stop_1_combo.SelectedIndex),
					Key2 = (ControlKey)Enum.GetValues(typeof(ControlKey)).GetValue(hk_stop_2_combo.SelectedIndex),
					Key3 = (AlphabeticKey)Enum.GetValues(typeof(AlphabeticKey)).GetValue(hk_stop_3_combo.SelectedIndex)
				}
			};
			Data.SaveSetting(st);
			Setting.Reload();
			
			Close();
		}
	}
}