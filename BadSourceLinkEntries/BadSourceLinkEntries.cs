﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSourceLinkEntries
{
    public class BadSourceLinkEntries
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
