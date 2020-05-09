using System.Windows.Forms;
using reaxlisten.speech;
using System.Threading;

namespace reaxlisten
{
	public class gHotKey
	{
		public ModifierKeys key1;
		public ModifierKeys key2;
		public Keys key3;
		
	} 
	public static class GlobalHotkey
	{
		private static KeyboardHook hook;
		private static gHotKey[] _gHotKeys;

		private static void Rome()
		{
			hook = new KeyboardHook();
			hook.KeyPressed += HookKeyPressed;
		}

		public static void Run()
		{
			if (hook is null)
				Rome();

			var st = Data.GetSetting();
			var d = new[] {st.PlayResume, st.Pause, st.Stop};
			_gHotKeys = new gHotKey[d.Length];

			ushort i = 0;
			foreach (var hk in d)
			{
				var ghk = GetHotKey(hk);
				_gHotKeys[i] = ghk;
				hook.RegisterHotKey(ghk.key1 | ghk.key2, ghk.key3);
				i++;
			}

		}

		
		private static void HookKeyPressed(object sender, KeyPressedEventArgs e)
		{
			//Play Resume
			if ((_gHotKeys[0].key1 | _gHotKeys[0].key2) == e.Modifier && _gHotKeys[0].key3 == e.Key)
			{
				Speech.PlayPauseAsync(Utils.GetClipboardText());
			}
			
			//Pause
			if ((_gHotKeys[1].key1 | _gHotKeys[1].key2) == e.Modifier && _gHotKeys[1].key3 == e.Key)
			{
				Speech.Pause();
			}
			
			//Stop
			if ((_gHotKeys[2].key1 | _gHotKeys[2].key2) == e.Modifier && _gHotKeys[2].key3 == e.Key)
			{
				Speech.Stop();
			}
			
		}
		
		private static gHotKey GetHotKey(HotKey stPlayResume)
		{
			var g = new gHotKey
			{
				key1 = GetModKey(stPlayResume.Key1),
				key2 = GetModKey(stPlayResume.Key2),
				key3 = GetKeysKey(stPlayResume.Key3)
			};

			return g;
		}

		private static ModifierKeys GetModKey(ControlKey cKey)
		{
			switch (cKey)
			{
				case ControlKey.CTRL:
					return ModifierKeys.Control;
				case ControlKey.ALT:
					return ModifierKeys.Alt;
				case ControlKey.SHIFT:
					return ModifierKeys.Shift;
				case ControlKey.NONE:
					return ModifierKeys.None;
				default:
					return ModifierKeys.None;
			}
		}

		private static Keys GetKeysKey(AlphabeticKey aKey)
		{
			switch (aKey)
			{
				case AlphabeticKey.A:
					return Keys.A;
				case AlphabeticKey.B:
					return Keys.B;
				case AlphabeticKey.C:
					return Keys.C;
				case AlphabeticKey.D:
					return Keys.D;
				case AlphabeticKey.E:
					return Keys.E;
				case AlphabeticKey.F:
					return Keys.F;
				case AlphabeticKey.G:
					return Keys.G;
				case AlphabeticKey.H:
					return Keys.H;
				case AlphabeticKey.I:
					return Keys.I;
				case AlphabeticKey.J:
					return Keys.J;
				case AlphabeticKey.K:
					return Keys.K;
				case AlphabeticKey.L:
					return Keys.L;
				case AlphabeticKey.M:
					return Keys.M;
				case AlphabeticKey.N:
					return Keys.N;
				case AlphabeticKey.O:
					return Keys.O;
				case AlphabeticKey.P:
					return Keys.P;
				case AlphabeticKey.Q:
					return Keys.Q;
				case AlphabeticKey.R:
					return Keys.R;
				case AlphabeticKey.S:
					return Keys.S;
				case AlphabeticKey.T:
					return Keys.T;
				case AlphabeticKey.U:
					return Keys.U;
				case AlphabeticKey.V:
					return Keys.V;
				case AlphabeticKey.W:
					return Keys.W;
				case AlphabeticKey.X:
					return Keys.X;
				case AlphabeticKey.Y:
					return Keys.Y;
				case AlphabeticKey.Z:
					return Keys.Z;
				case AlphabeticKey.F1:
					return Keys.F1;
				case AlphabeticKey.F2:
					return Keys.F2;
				case AlphabeticKey.F3:
					return Keys.F3;
				case AlphabeticKey.F4:
					return Keys.F4;
				case AlphabeticKey.F5:
					return Keys.F5;
				case AlphabeticKey.F6:
					return Keys.F6;
				case AlphabeticKey.F7:
					return Keys.F7;
				case AlphabeticKey.F8:
					return Keys.F8;
				case AlphabeticKey.F9:
					return Keys.F9;
				case AlphabeticKey.F10:
					return Keys.F10;
				case AlphabeticKey.F11:
					return Keys.F11;
				case AlphabeticKey.F12:
					return Keys.F12;
				case AlphabeticKey.F13:
					return Keys.F13;
				default:
					return Keys.F10;
			}
		}

		public static void Stop()
		{
			hook.UnregisterAll();
			Thread.Sleep(100);
			hook = null;
		}

		public static void Reload()
		{
			Stop();
			Thread.Sleep(300);
			Run();
		}
		
		
	}
}