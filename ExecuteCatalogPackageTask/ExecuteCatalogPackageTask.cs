using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Management.IntegrationServices;
using Microsoft.SqlServer.Management.Smo;

namespace ExecuteCatalogPackageTask
{
    [DtsTask(DisplayName ="ExecuteCatalogPackageTask",
             Description ="A task to execute packages stored in the SSIS Catalog.",
             UITypeName = "ExecuteCatalogPackageTaskUI.ExecuteCatalogPackageTaskUI,ExecuteCatalogPackageTaskUI,Version=1.0.0.0," +
             "Culture=neutral," +
             "PublicKeyToken=e598017cfc235f73",
             IconResource = "ExecuteCatalogPackageTask.ExecuteCatalogPackageTask.ico"
        )]
    public class ExecuteCatalogPackageTask : Task
    {   

        public string ServerName { get; set; }
        public string PackageCatalog { get; set; } = "SSISDB";
        public string PackageFolder { get; set; }
        public string PackageProject { get; set; }
        public string PackageName { get; set; }

        //Public key:  e598017cfc235f73
        //             e598017cfc235f73

        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {
            //base.InitializeTask(connections, variableDispenser, events, log, eventInfos, logEntryInfos, refTracker);
        }

        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            //return base.Validate(connections, variableDispenser, componentEvents, log);
            return DTSExecResult.Success;
        }

        public override DTSExecResult Execute(Connections connections, 
                                              VariableDispenser variableDispenser, 
                                              IDTSComponentEvents componentEvents, 
                                              IDTSLogging log, 
                                              object transaction)
        {
            //return base.Execute(connections, variableDispenser, componentEvents, log, transaction);
            Server catalogServer = new Server(ServerName);
            IntegrationServices integrationServices = new IntegrationServices(catalogServer);
            Catalog catalog = integrationServices.Catalogs[PackageCatalog];
            CatalogFolder catalogFolder = catalog.Folders[PackageFolder];
            ProjectInfo catalogProject = catalogFolder.Projects[PackageProject];
            Microsoft.SqlServer.Management.IntegrationServices.PackageInfo catalogPackage = catalogProject.Packages[PackageName+".dtsx"];

            catalogPackage.Execute(false, null);

            return DTSExecResult.Success;
        }
    }
}
