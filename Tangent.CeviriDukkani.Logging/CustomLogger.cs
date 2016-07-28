using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;

namespace Tangent.CeviriDukkani.Logging {
    public class CustomLogger {

        //public static ILog Logger {
        //    get {
        //        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //        path = $"{path}/log4net.config";
        //        log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(path));
        //        var logger = LogManager.GetLogger(typeof(CustomLogger));
        //        return logger;
        //    }
        //}
        static CustomLogger() {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = $"{path}/log4net.config";
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(path));
            Logger = LogManager.GetLogger(typeof(CustomLogger));
        }

        public static ILog Logger { get; set; }
    }
}
