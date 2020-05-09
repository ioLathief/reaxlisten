using System;

namespace reaxlisten
{
	public enum ControlKey
	{
		CTRL,
		ALT,
		SHIFT,
		NONE
	}

	public enum AlphabeticKey
	{
		A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,F1,F2,F3,F4,F5,F6,F7,F8,F9,F10,F11,F12,F13
	}
	public class HotKey
	{
		public ControlKey Key1 { get; set; }
		public ControlKey Key2 { get; set; }
		public AlphabeticKey Key3 { get; set; }
	}
}