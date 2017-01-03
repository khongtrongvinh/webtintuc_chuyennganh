using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using weptintuc.Models;
using PagedList.Mvc;
using PagedList;

namespace weptintuc.Controllers
{
    public class TimkiemController : Controller
    {
        dbNewsDataContext data = new dbNewsDataContext();
        // GET: Timkiem
        [HttpPost]
        public ActionResult ketquatimkiem(FormCollection f, int? page)
        {
            string stukhoa = f["tukhoa"].ToString();
            ViewBag.TuKhoa = stukhoa;
            List<TIN_TUC> lstKQTK = data.TIN_TUCs.Where(n => n.TEN_TT.Contains(stukhoa)).ToList();
            //phan trang 
            int pageSize = 8;
            int pageNum = (page ?? 1);
            if (lstKQTK.Count==0)
            {
                ViewBag.Thongbao = "Không tìm thấy tin tức nào liên quan đến từ khoá!";
                    return View(data.TIN_TUCs.OrderBy(n => n.TEN_TT).ToPagedList(pageNum,pageSize));
            }
            ViewBag.Thongbao = "Đã tìm thấy" +" "+ lstKQTK.Count + " kết quả !";
            return View(lstKQTK.OrderBy(n=>n.TEN_TT).ToPagedList(pageNum, pageSize));
        }


        [HttpGet]
        public ActionResult ketquatimkiem(string stukhoa, int? page)
        {
            ViewBag.TuKhoa = stukhoa;
            
            List<TIN_TUC> lstKQTK = data.TIN_TUCs.Where(n => n.TEN_TT.Contains(stukhoa)).ToList();
            //phan trang 
            int pageSize = 8;
            int pageNum = (page ?? 1);
            if (lstKQTK.Count == 0)
            {
                ViewBag.Thongbao = "Không tìm thấy tin tức nào liên quan đến từ khoá!";
                return View(data.TIN_TUCs.OrderBy(n => n.TEN_TT).ToPagedList(pageNum, pageSize));
            }
            ViewBag.Thongbao = "Đã tìm thấy" + lstKQTK.Count + " kết quả !";
            return View(lstKQTK.OrderBy(n => n.TEN_TT).ToPagedList(pageNum, pageSize));
        }
    }
}