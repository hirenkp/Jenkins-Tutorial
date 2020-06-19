using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsConsole;

namespace JenkinsTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(Program.CreateMessage(), "Hello World 2");
		}
	}
}
