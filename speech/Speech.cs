using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Speech.Synthesis;

namespace reaxlisten.speech
{
    public static class Speech
    {
        private static readonly string _lastText;
        private static status _status;
        
        static Speech()
        {
            _synthesizer = new SpeechSynthesizer();
            _lastText = "";
            _status = status.Stopped;
            InitVoiceNames();
        }

        public static void Volume(UInt16 volume) => _synthesizer.Volume = volume;

        public static void Rate(UInt16 rate) => _synthesizer.Rate = rate;

        public static void SpeakAsync(string text) => _synthesizer.SpeakAsync(text);

        public static void Speak(string text) => _synthesizer.Speak(text);

        public static void Speak()
        {
            if (_lastText == "")
                return;
            _synthesizer.Speak(_lastText);
        }

        public static void SetSynthVoice(string voice)
        {
            if (_voicesNames.All(voiceName => voice != voiceName)) return;
            _synthesizer.SelectVoice(voice);
        }
        
        public static string[] GetVoicesNames() => _voicesNames;

        public static void Resume() => _synthesizer.Resume();

        public static void Stop() => _synthesizer.Pause();

        public static void Pause() => _synthesizer.Pause();

        public static void Save(string text, string location)
        {
            
        }

        public static void Save(string locaion)
        {
            Save(_lastText, locaion);
        }

        public static void Restart()
        {
            
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
        
        private static readonly SpeechSynthesizer _synthesizer;
        private static string[] _voicesNames;
    }

    enum status
    {
        Playing,
        Stopped,
        Paused,
    }
}