using System;
using System.Collections.Generic;

namespace Net.XpForge.INotify
{

	public class Arguments
	{
		// Default values
		private List<string> _Events = new List<string>(new string[] { "create", "modify", "delete", "move" });
		private string[] _Format = new string[] { "e", "\": ", "f" };

		public bool Recursive { get; set; }
		public bool Monitor { get; set; }
		public bool Quiet { get; set; }
		public string Path { get; set; }
		public string[] Format { 
			get { return this._Format; }
			set { this._Format = value; }
		}
		public List<string> Events
		{
			get { return this._Events; }
			set { this._Events = value; }
		}
	}
}