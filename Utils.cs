using System;
using System.Windows.Forms;

namespace reaxlisten
{
	public static class Utils
	{
		public static String SwapClipboardHtmlText(String replacementHtmlText)
		{
			string returnHtmlText = null;
			if (!Clipboard.ContainsText(TextDataFormat.Html)) return returnHtmlText;
			
			returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
			Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);

			return returnHtmlText;
		}

		public static string GetHtml()
		{
			if (!Clipboard.ContainsText(TextDataFormat.Html)) return "";
			var returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
			return returnHtmlText;
		}

		public static string GetClipboardText()
		{
			if (!Clipboard.ContainsText(TextDataFormat.Text)) return "";
			var returnHtmlText = Clipboard.GetText(TextDataFormat.Text);
			return returnHtmlText;
		}
	}
}