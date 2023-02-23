using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MijnClasses
{
    public class TestClass
    {
        public string teststring="";
        public int testint;
        public /* unsafe */ void TestIt() // let op: zet in Project/properties/Unsafe code aan.
        {
            var ts = teststring;
            //char* t = (char*)&ts;
            //*t = 'A';
            //t = (char *) 0x5;
            //*t = 'B';

            if (teststring == null) ts = "pihhhet";
            //var ts = (teststring == null) ? "pihhhhet" : teststring;
            //var ts = teststring ?? "pihhh?het";
            testint = 100;
            Console.WriteLine($"Testing: {ts}, {testint}"); // waar due Console output naar toe?
        }
    }
}
