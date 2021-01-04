using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DataMAN
{
    static class PluginManager
    {
        private static IAnalizer _plugin;

        public static void LoadPlugin(string file , Panel panelC , Panel panelV )
        {
            if (File.Exists(file))
            {
                UnloadPlugins();
                Assembly assembly = Assembly.LoadFrom(file);
                Type pluginType = typeof(IAnalizer);
                Type[] types = assembly.GetTypes();
                foreach (Type t in types)
                {
                    if (t.GetInterface(pluginType.FullName) != null)
                    {
                        _plugin = (IAnalizer)Activator.CreateInstance(t);
                        _plugin.Load(panelC, panelV );
                    }
                }
            }
        }

        public static void UnloadPlugins()
        {
            if (_plugin != null)
            {
                _plugin.UnLoad();
                _plugin = null;
            }
        }
    }
}
