using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedPdb
{
    public class EmbeddedPdb
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
