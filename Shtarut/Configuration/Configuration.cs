using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shtarut.Configuration
{
    internal static class Configuration
    {
        public static string ShtarotPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Shtarot.xml"
            );
    }
}
