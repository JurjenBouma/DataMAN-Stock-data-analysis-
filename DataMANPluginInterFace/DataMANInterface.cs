using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMAN
{
    public interface IAnalizer
    {
        string Name { get; }
        void Load(Panel controlPanel , Panel variablesPanel);
        void UnLoad();
    }
}
