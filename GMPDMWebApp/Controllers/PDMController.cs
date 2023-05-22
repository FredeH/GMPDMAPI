using EPDM.Interop.epdm;
using GMPDMWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GMPDMWebApp.Controllers
{
    [EnableCors(origins: "http://192.168.1.199:3000", headers: "*", methods: "*")]
    [RoutePrefix("api/pdm")]
    public class PDMController : ApiController
    {
        //IEdmVault21 vault = new EdmVault5() as IEdmVault21;

        //private IEdmSearchResult5 SearchFileName(string fileName)
        //{
        //    IEdmSearch5 search = vault.CreateSearch2();
        //    search.FindFiles = true;
        //    search.FindFolders = false;
        //    search.FileName = fileName;

        //    return search.GetFirstResult();
        //}

        [Route("{fileName}")]
        public File[] GetFile(string fileName)
        {
            //var results = SearchFileName(fileName);

            return new File[]
            {
                new File
                {
                    FileName = fileName + ".slddrw",
                    Path = "C:/GMPDM/" + fileName + ".slddrw"
                },
                new File
                {
                    FileName = fileName + ".sldprt",
                    Path = "C:/GMPDM/" + fileName + ".sldprt"
                },
            };
        }

        //[Route("{fileName}/task")]
        //public void SetTask(string fileName)
        //{
        //    IEdmTaskMgr taskMgr = vault.CreateUtility(EdmUtility.EdmUtil_TaskMgr);
        //    EdmTaskInfo[] tasks = taskMgr.GetTasks();
        //    EdmTaskInfo pdfConvert = tasks[3];

        //    var results = SearchFileName(fileName);

        //    EdmSelItem2 convertItem = new EdmSelItem2();
        //    convertItem.mlID = results.ID;
        //    convertItem.mlParentID = results.ParentFolderID;
        //    convertItem.mlVersion = results.Version;
        //    convertItem.meType = EdmObjectType.EdmObject_File;

        //    EdmSelItem2[] selections = new EdmSelItem2[0];
        //    selections[0] = convertItem;

        //    taskMgr.RunTask(pdfConvert, selections, 0);
        //}

    }
}
