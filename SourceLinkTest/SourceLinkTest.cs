using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SourceLinkTest
{
    class SourceLinkTest
    {
        static void Main(string[] args)
        {
            while (true)
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

                BadSourceLink.BadSourceLink.Method();
                BadSourceLinkEntries.BadSourceLinkEntries.Method();
                AbsoluteMappings.Absolute1.Method();
                AbsoluteMappings.Absolute2.Method();
                EmbeddedPdb.EmbeddedPdb.Method();
                VSOSourceLink.VSOSourceLink.Method();
                PortableNoSourceLink.PortableNoSourceLink.Method();
                HttpSourceLink.HttpSourceLink.Method();
                Timeout.Timeout.Method();
            }
        }
    }
}
