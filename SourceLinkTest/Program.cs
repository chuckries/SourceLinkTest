using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SourceLinkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!System.Diagnostics.Debugger.IsAttached)
            {
                Thread.Sleep(100);
            }

            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {

            }

            BadSourceLink.Class1.Method();
            BadSourceLinkEntries.Class1.Method();
            AbsoluteMappings.Class1.Method();
            AbsoluteMappings.Class2.Method();
        }
    }
}
