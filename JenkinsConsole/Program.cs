using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsConsole
{
	public class Program
	{
		static void Main(string[] args)
		{
			string msg = CreateMessage();
			Console.WriteLine(msg);
		}

		public static string CreateMessage()
		{
			return "Hello World 3";
		}
	}
}
