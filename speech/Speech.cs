using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using NAudio.Lame;
using NAudio.Wave;

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

		private static void Init()
		{
			_synthesizer = new SpeechSynthesizer();
			_lastText = "";
			_status = status.Stopped;
			_synthesizer.Volume = 100;
			_synthesizer.Rate = 0;
			InitVoiceNames();
			_synthesizer.SpeakCompleted += Reader_SpeakCompleted;

		}

		public static void Volume(UInt16 volume) => _synthesizer.Volume = volume;

		public static void Rate(UInt16 rate)
		{
			if (0 > rate || rate > 100) return;
			double val = rate * 20 / 100;
			_synthesizer.Rate = (int) (val - 10);
		}

		public static status GetStatus()
		{
			return _status;
		}
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

		public static void SetSynthVoice(string voice)
		{
			if (_voicesNames.All(voiceName => voice != voiceName)) return;
			_synthesizer.SelectVoice(voice);
		}

		public static string[] GetVoicesNames() => _voicesNames;

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
			if (_status == status.Paused || _status == status.Stopped)
				if (text == "")
					PlayAsync();
				else
					PlayAsync(text);
			else
				Pause();
		}

		private static void Reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
		{
			_status = status.Stopped;
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
		}

		public static void Pause()
		{
			if (_status == status.Paused || _status == status.Stopped) return;
			_status = status.Paused;
			_synthesizer.Pause();
		}

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

		public static void Restart()
		{
			Init();
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

		public static void ConvertWavStreamToMp3File(ref MemoryStream ms, string savetofilename)
		{
			//rewind to beginning of stream
			ms.Seek(0, SeekOrigin.Begin);

			using (var retMs = new MemoryStream())
			using (var rdr = new WaveFileReader(ms))
			using (var wtr = new LameMP3FileWriter(savetofilename, rdr.WaveFormat, LAMEPreset.VBR_90))
			{
				rdr.CopyTo(wtr);
			}
		}

		private static SpeechSynthesizer _synthesizer;
		private static string[] _voicesNames;
	}

	public enum status
	{
		Playing,
		Stopped,
		Paused,
	}
}