using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopPdb
{
    public class DesktopPdb
    {
        public static void Method()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {

            }
        }
    }
}
