using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;

namespace ExecuteCatalogPackageTaskUI
{
    public class ExecuteCatalogPackageTaskUI : IDtsTaskUI
    {
        private TaskHost taskHostValue;

        public ExecuteCatalogPackageTaskUI()
        {
        }

        System.Windows.Forms.ContainerControl IDtsTaskUI.GetView()
        {
            return new ExecuteCatalogPackageTaskForm(taskHostValue);
        }

        void IDtsTaskUI.New(IWin32Window parentWindow)
        {
        }
        void IDtsTaskUI.Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            taskHostValue = taskHost;
        }

        void IDtsTaskUI.Delete(System.Windows.Forms.IWin32Window parentWindow)
        {
        }





        
    }
}
