using IConduct.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medica.IConductPlugins
{
    public class EmptyPluginTest : IPlugin
    {
        public bool Execute(PluginParam param)
        {
            throw new NotImplementedException();
        }
    }
}
