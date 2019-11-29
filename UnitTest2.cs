using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public void verfiy_UnitTest2()
        {
            Console.WriteLine("sayan");
			//console .writeline("brijendra");
			//console window shows


        }

      
    
        [TestMethod]
        public void TestMethod1()
        {
        UnitTest2 ut = new UnitTest2();
        ut.verfiy_UnitTest2();
        }
    }
}
