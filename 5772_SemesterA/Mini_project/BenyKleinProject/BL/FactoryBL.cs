﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class FactoryBL
    {
        public static IBL getBL()
        {
            return new BL_Basic();
        }
    }
}
