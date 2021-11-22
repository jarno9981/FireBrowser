using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBrowser.Converters
{
    internal class IOptimize
    {
        enum memory
        {
            full = 0,
            unload = 1,
            load = 2
        };

        memory mem = new memory();
    }
}
