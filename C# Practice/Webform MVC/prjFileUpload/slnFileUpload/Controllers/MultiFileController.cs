using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace slnFileUpload.Controllers
{
    public class MultiFileController : Controller
    {
        // GET: MultiFile
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase[] photos)
        {
            string fname = "";
            //使用for迴圈取得所有上傳檔案
            for (int i = 0; i < photos.Length; i++)
            {
                //取得目前檔案上傳的HttpPostedFileBase物件
                //即虛引數的photos[i]可以取得第i個所上傳的檔案
                HttpPostedFileBase f = (HttpPostedFileBase)photos[i];
                //若目前檔案上傳的HttpPostedFileBase物件檔案名成為不空白
                //即表示第i個f物件有指定上傳檔案
                if (f != null)
                {
                    //取得上傳檔案名稱
                    fname = f.FileName.Substring(f.FileName.LastIndexOf("\\") + 1);
                    //講檔案存到網站的files資料夾下
                    f.SaveAs(Server.MapPath("~/Photos") + "\\" + fname);
                }
            }
            return RedirectToAction("showPhotos");
        }

        //shoewphotos 方法可顯示photos資料夾所有圖檔
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
                if (n % 4 == 0)  //若顯示四個圖之後將跳一個段落
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