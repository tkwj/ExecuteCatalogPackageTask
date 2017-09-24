using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Collections;
using Microsoft.SqlServer.Dts.Runtime;

namespace ExecuteCatalogPackageTaskUI
{
    public partial class ExecuteCatalogPackageTaskForm : Form
    {
        private TaskHost taskHostValue;
        public ExecuteCatalogPackageTaskForm(TaskHost taskHost)
        {
            InitializeComponent();
            taskHostValue = taskHost;
            txtInstance.Text = Convert.ToString(taskHostValue.Properties["ServerName"].GetValue(taskHostValue));
            txtFolder.Text = Convert.ToString(taskHostValue.Properties["PackageFolder"].GetValue(taskHostValue));
            txtProject.Text = Convert.ToString(taskHostValue.Properties["PackageProject"].GetValue(taskHostValue));
            txtPackage.Text = Convert.ToString(taskHostValue.Properties["PackageName"].GetValue(taskHostValue));
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            taskHostValue.Properties["ServerName"].SetValue(taskHostValue, Convert.ToString(txtInstance.Text));
            taskHostValue.Properties["PackageFolder"].SetValue(taskHostValue, Convert.ToString(txtFolder.Text));
            taskHostValue.Properties["PackageProject"].SetValue(taskHostValue, Convert.ToString(txtProject.Text));
            taskHostValue.Properties["PackageName"].SetValue(taskHostValue, Convert.ToString(txtPackage.Text));
        }
    }
}
