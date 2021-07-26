using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManagementTwo.Controllers
{
    public class NewbookController : Controller
    {
        // GET: Newbook
        public ActionResult Index()
        {
            return View();
        }
        #region 上传
        public JsonResult UploadFile()                                    //图片上传
        {
            Stream uploadStream = null;
            FileStream fs = null;
            try
            {
                //文件上传，一次上传1M的数据，防止出现大文件无法上传  
                HttpPostedFileBase postFileBase = Request.Files["image"];
                uploadStream = postFileBase.InputStream;
                int bufferLen = 1024;//KB
                byte[] buffer = new byte[bufferLen];
                int contentLen = 0;

                string fileName = Path.GetFileName(postFileBase.FileName);
                string baseUrl = Server.MapPath("/");
                if (!Directory.Exists(baseUrl + @"img\"))
                {
                    Directory.CreateDirectory(baseUrl + @"img\");
                }
                string uploadPath = baseUrl + @"img\" + @"\";
                fs = new FileStream(uploadPath + fileName, FileMode.Create, FileAccess.ReadWrite);

                while ((contentLen = uploadStream.Read(buffer, 0, bufferLen)) != 0)
                {
                    fs.Write(buffer, 0, bufferLen);
                    fs.Flush();
                }

                string FileName = "";
                FileName = @"img\" + fileName;
                string fileNames = "img/" + fileName;
                return Json(fileNames);
            }
            catch (Exception ex)
            {
                ex.StackTrace.ToString();
                return Json("Error");
            }
            finally
            {
                if (null != fs)
                {
                    fs.Close();
                }
                if (null != uploadStream)
                {
                    uploadStream.Close();
                }
            }

        }


        #endregion



    }
}