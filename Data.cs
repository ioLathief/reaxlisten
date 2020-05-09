using System;
using Json.Net;
using System.IO;

namespace reaxlisten
{
	public static class Data
	{
		static Data()
		{
			if (!File.Exists(_settingFilePath))
			{
				SaveFile(JsonNet.Serialize(Setting.GetDefaultSetting()));
				_setting = Setting.GetDefaultSetting();
			}
			else
			{
				_setting = JsonNet.Deserialize<Setting>(GetFileData());
			}
		}

		
		public static Setting GetSetting()
		{
			return _setting;
		}

		public static void SaveSetting(Setting st)
		{
			_setting = st;
			SaveFile(JsonNet.Serialize(st));
		}
		

		private static bool SaveFile(string data)
		{
			try
			{
				File.WriteAllText(_settingFilePath, data);
			}
			catch (Exception Ex)
			{
				Console.WriteLine(Ex.ToString());
				return false;
			}

			return true;
		}

		private static string GetFileData()
		{
			string s;
			using (var sr = File.OpenText(_settingFilePath))    
			{    
				s = sr.ReadToEnd();    
			}

			return s;
		}
		
		private static Setting _setting;
		private const string _settingFilePath = @"setting.json";
		private static Setting _default_setting;
	}
}