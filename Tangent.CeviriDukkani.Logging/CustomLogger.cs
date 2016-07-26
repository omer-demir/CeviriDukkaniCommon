using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;

namespace Tangent.CeviriDukkani.Logging {
    public class CustomLogger {
        public static ILog Logger;

        static CustomLogger() {
            Logger = LogManager.GetLogger(typeof(CustomLogger));
        }
    }
}
