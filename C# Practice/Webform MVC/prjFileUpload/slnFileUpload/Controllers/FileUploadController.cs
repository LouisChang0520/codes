﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace slnFileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            //上傳圖檔
            string fileName = "";
            //檔案上傳
            if (photo != null)
            {
                if (photo.ContentLength > 0)
                {
                    //取得圖檔名稱
                    fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);
                    photo.SaveAs(path);
                }
            }
            return RedirectToAction("ShowPhotos");
        }

        //ShowPhotos方法顯示Photos內所有圖檔
        public string ShowPhotos()
        {
            string show = "";
            //建立可操作photos的dir物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
            //取得dir物件下的所有檔案並放入finfo檔案資訊陣列
            FileInfo[] fInfo = dir.GetFiles();
            int n = 0;
            //逐一將finfo檔案資訊陣列內的所有圖檔指定給show變數
            foreach (FileInfo result in fInfo)
            {
                n++;
                //將目前取得的圖顯示在lblshow標籤內
                show += "<a href = '../Photos/" + result.Name + "'target = '_blank'><img src = '../Photos/" + result.Name + "'width= '90' height = '60' border ='0'></a> ";
                if (n % 4 == 0)
                {
                    show += "<p>";
                }
            }
            //show變數再加上'返回'Create動作方法的連結
            show += "<p><a href = 'Create'>返回</a></p>";
            return show;
        }
    }
}