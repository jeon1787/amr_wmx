using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amr_wmx
{
    public class AClassSupporter
    {
        public static WMXController manualController = WMXController.GetInstance();
        public static WMXController statusController = WMXController.NewInstance();
    }
}
