﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeout
{
    public class Timeout
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
