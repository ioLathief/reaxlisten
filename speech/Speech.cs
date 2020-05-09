using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;

namespace reaxlisten.speech
{
	public static class Speech
	{
		private static string _lastText;
		private static status _status;

		static Speech()
		{
			Init();
		}

		
		/*
		 * Initializers
		 */
		private static void Init()
		{
			_status = status.Stopped;
			_lastText = "";
			_selectedVoiceIndex = (ushort) Data.GetSetting().SelectedVoice;
			_rate = (ushort) Data.GetSetting().Rate;
			_volume = (ushort) Data.GetSetting().Volume;
			InitSynthesizer();
		}

		private static void InitSynthesizer()
		{
			_synthesizer = new SpeechSynthesizer();
			InitVoiceNames();
			_synthesizer.SpeakCompleted += Reader_SpeakCompleted;
			Rate(_rate);
			Volume(_volume);
			SetSynthVoice(_voicesNames[_selectedVoiceIndex]);
		}

		
		private static void InitVoiceNames()
		{
			var voe = _synthesizer.GetInstalledVoices();
			var voices = new string[voe.Count];
			var i = 0;
			foreach (var installedVoice in voe)
			{
				voices[i] = installedVoice.VoiceInfo.Name;
				i++;
			}

			_voicesNames = voices;
		}

		
		/*
		 * Getters and Setters
		 */
		//0 to 100
		public static void Volume(ushort volume) => _synthesizer.Volume = volume;
		
		// valid value is 0 to 100
		public static void Rate(ushort rate)
		{
			if (0 > rate || rate > 100) return;
			double val = rate * 20 / 100;
			_synthesizer.Rate = (int) (val - 10);
		}

		public static void SetSynthVoice(string voice)
		{
			if (_voicesNames.All(voiceName => voice != voiceName)) return;
			_synthesizer.SelectVoice(voice);
		}

		
		public static string[] GetVoicesNames() => _voicesNames;

		public static status GetStatus()
		{
			return _status;
		}

		public static int GetSelectedVoiceIndex()
		{
			return _selectedVoiceIndex;
		}


		/*
		 *
		 * Play Pause Controls
		 */
		public static void PlayAsync(string text = "")
		{
			if (text == "")
			{
				if (_lastText == "")
					return;
			}
			else
				_lastText = text;

			_status = status.Playing;
			
			_synthesizer.SpeakAsync(_lastText);
		}

		public static void Play(string text = "")
		{
			if (text == "")
			{
				if (_lastText == "")
					return;
			}
			else
				_lastText = text;

			_status = status.Playing;
			_synthesizer.Speak(_lastText);
		}

		public static void PlayPause(string text = "")
		{
			if (_status == status.Paused || _status == status.Stopped)
				if (text == "")
					Play();
				else
					Play(text);
			else
				Pause();
		}

		public static void PlayPauseAsync(string text = "")
		{
			if (_status == status.Stopped)
			{
				if (text == "")
					PlayAsync();
				else
					PlayAsync(text);
			}
			else if (_status == status.Paused)
			{
				Resume();	
			}
			else
				Pause();
		}

		public static void Resume()
		{
			if (_status == status.Playing) return;
			_synthesizer.Resume();
			_status = status.Playing;
		}

		public static void Stop()
		{
			_status = status.Stopped;
			_synthesizer.Pause();
			_synthesizer.Dispose();
			RestartSynthesizer();
		}

		public static void Pause()
		{
			if (_status == status.Paused || _status == status.Stopped) return;
			_status = status.Paused;
			_synthesizer.Pause();
		}

		
		/*
		 * Others
		 */
		
		// ReSharper disable once MemberCanBePrivate.Global
		public static void Save(string text, string location)
		{
			//todo: sample per setting 
			MemoryStream ms = new MemoryStream();
			// _synthesizer.SetOutputToWaveStream(ms);

			_synthesizer.SetOutputToWaveFile(location,
				new SpeechAudioFormatInfo(16000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
			_synthesizer.Speak(text);
			// ConvertWavStreamToMp3File(ref ms,location);
		}

		public static void Save(string locaion)
		{
			Save(_lastText, locaion);
		}

		private static void Reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
		{
			_status = status.Stopped;
		}

		public static void RestartSynthesizer()
		{
			InitSynthesizer();
		}


		/*
		 * private variables
		 */
		private static SpeechSynthesizer _synthesizer;

		private static ushort _volume;
		private static ushort _rate; // 0 to 100
		private static ushort _selectedVoiceIndex;
		
		private static string[] _voicesNames;
	}

	public enum status
	{
		Playing,
		Stopped,
		Paused,
	}
}