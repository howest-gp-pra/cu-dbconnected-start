using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.DBConnected.CORE
{
    public class Helper
    {
        public static string GetConnectionString()
        {
            // PAS ONDERSTAANDE CONNECTIESTRING AAN

            return @"Data Source=DESKTOP-O3H1S4C\SQLEXPRESS;Initial Catalog = Bibliotheek; Integrated security = true;";
        }
        public static string HandleQuotes(string waarde)
        {
            return waarde.Trim().Replace("'", "''");
        }
    }
}
