﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.DBConnected.CORE
{
    public class Helper
    {
        public static string HandleQuotes(string waarde)
        {
            return waarde.Trim().Replace("'", "''");
        }
    }
}
