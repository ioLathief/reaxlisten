using reaxlisten.speech;

namespace reaxlisten
{
	public class Setting
	{
		public int SelectedVoice { get; set; }
		public int Volume { get; set; }
		public int Rate { get; set; }

		public HotKey PlayResume { get; set; }

		public HotKey Pause { get; set; }

		public HotKey Stop { get; set; }

		public static Setting GetDefaultSetting()
		{
			return new Setting
			{
				SelectedVoice = 0,
				Rate = 50,
				Volume = 100,
				PlayResume = new HotKey {Key1 = ControlKey.CTRL, Key2 = ControlKey.ALT, Key3 = AlphabeticKey.D},
				Pause = new HotKey {Key1 = ControlKey.CTRL, Key2 = ControlKey.ALT, Key3 = AlphabeticKey.D},
				Stop = new HotKey {Key1 = ControlKey.CTRL, Key2 = ControlKey.ALT, Key3 = AlphabeticKey.D}
			};
		}

		public static void Reload()
		{
			var st = Data.GetSetting();
			Speech.Stop();
			//Voice
			Speech.SetSynthVoice(Speech.GetVoicesNames()[st.SelectedVoice]);
			
			//Rate
			Speech.Rate((ushort)st.Rate);
			
			//Volume
			Speech.Volume((ushort)st.Volume);
			
			GlobalHotkey.Reload();
		}
	}
}