using System.Linq;
using System.Web.Mvc;
using weptintuc.Models;
using PagedList;
using System.Web;
using System.IO;

namespace weptintuc.Controllers
{
    public class AdminController : Controller
    {
        dbNewsDataContext data = new dbNewsDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection colec)
        {
            var tendn = colec["Username"];
            var matkhau = colec["Password"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập !";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu !";
            }
            else
            {
                TAI_KHOAN ad = data.TAI_KHOANs.SingleOrDefault(n => n.TEN_TAI_KHOAN == tendn && n.MAT_KHAU == matkhau);
                if (ad != null)
                {
                    Session["TaiKhoanAdmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Thongbao = "Tài khoản hoặc mật khẩu ko đúng";
                }

            }
            return View();
        }
        public ActionResult DangxuatAdmin(FormCollection f)
        {
            Session["TaiKhoanAdmin"] = null;
            return RedirectToAction("Login", "Admin");
        }


        public ActionResult TinTuc(int? page)
        {
            int sotrang = (page ?? 1);
            int kichthuoctrang = 20;
            return View(data.TIN_TUCs.OrderByDescending(n => n.MATT).ToPagedList(sotrang, kichthuoctrang));
        }
        public ActionResult LoaiTinTuc(int? page)
        {
            int sotrang = (page ?? 1);
            int kichthuoctrang = 7;
            return View(data.LOAI_TINs.ToPagedList(sotrang, kichthuoctrang));
        }
        public ActionResult TaiKhoan(int? page)
        {
            int sotrang = (page ?? 1);
            int kichthuoctrang = 7;
            return View(data.TAI_KHOANs.ToPagedList(sotrang, kichthuoctrang));
        }
        public ActionResult user(int? page)
        {
            int sotrang = (page ?? 1);
            int kichthuoctrang = 8;
            return View(data.KHACH_HANGs.ToPagedList(sotrang, kichthuoctrang));
        }

        [HttpGet]
        public ActionResult ThemTT()
        {
            ViewBag.MA_LOAI_TT = new SelectList(data.LOAI_TINs.ToList(), "MA_LOAI_TT", "TEN_LOAI_TT");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemTT(TIN_TUC tin, HttpPostedFileBase Upload)
        {
            ViewBag.MA_LOAI_TT = new SelectList(data.LOAI_TINs.ToList(), "MA_LOAI_TT", "TEN_LOAI_TT");
            if (Upload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var filename = Path.GetFileName(Upload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/img"), filename);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";

                    }
                    else
                    {
                        Upload.SaveAs(path);
                        tin.HINH_ANH = filename;
                    }
                   
                    data.TIN_TUCs.InsertOnSubmit(tin);
                    data.SubmitChanges();

                }
                return RedirectToAction("TinTuc");
            }
        }
        


        public ActionResult ChiTietTinTuc(int id)
        {
            TIN_TUC tin = data.TIN_TUCs.SingleOrDefault(n => n.MATT == id);
            ViewBag.MATT = tin.MATT;
            if (tin == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tin);

        }
        [HttpGet]
        public ActionResult Xoatintuc(int id)
        {
            TIN_TUC tintuc = data.TIN_TUCs.SingleOrDefault(n => n.MATT == id);
            ViewBag.MaTT = tintuc.MATT;
            if (tintuc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tintuc);
        }
        [HttpPost, ActionName("Xoatintuc")]
        public ActionResult Xacnhanxoa(int id)
        {
            //lay ra doi tuong tin can xoa theo ma
            TIN_TUC tincanxoa = data.TIN_TUCs.SingleOrDefault(n => n.MATT == id);
            if (tincanxoa == null)
            {
                Response.StatusCode = 404;
                return null;

            }
            data.TIN_TUCs.DeleteOnSubmit(tincanxoa);
            data.SubmitChanges();
            return RedirectToAction("TinTuc");
        }
        // Chinh sua tin tuc
        [HttpGet]
        public ActionResult Suatintuc(int id)
        {
            var tt = data.TIN_TUCs.SingleOrDefault(n => n.MATT == id);
            ViewBag.MA_LOAI_TT = new SelectList(data.LOAI_TINs, "MA_LOAI_TT", "TEN_LOAI_TT", tt.MA_LOAI_TT);
            return View(tt);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Suatintuc(TIN_TUC model, FormCollection collection, HttpPostedFileBase upload,int id)
        {
            ViewBag.MA_LOAI_TT = new SelectList(data.LOAI_TINs.OrderBy(n=>n.TEN_LOAI_TT),"MA_LOAI_TT","TEN_LOAI_TT");
            var tt = data.TIN_TUCs.First(n => n.MATT == id);
            
            
            if (upload == null)
            {
                UpdateModel(tt);
                data.SubmitChanges();
                return RedirectToAction("TinTuc");
                
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var name = Path.GetFileName(upload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/img"), name);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        upload.SaveAs(path);
                    }
                    tt.HINH_ANH = name;
                    tt.MATT = id;
                  
                    UpdateModel(tt);
                    data.SubmitChanges();
                }
                return this.Suatintuc(id);
            }
        }
        public ActionResult ThemLoaiTin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemLoaiTin(LOAI_TIN lt)
        {
            data.LOAI_TINs.InsertOnSubmit(lt);
            data.SubmitChanges();
            return RedirectToAction("LoaiTinTuc");
        }
        //public ActionResult ChitietLT(int ma)
        //{
        //    LOAI_TIN lt = data.LOAI_TINs.SingleOrDefault(n => n.MA_LOAI_TT == ma);
        //    ViewBag.MA_LOAI_TT = lt.MA_LOAI_TT;
        //    if (lt == null)
        //    {
        //        Response.StatusCode = 404;
        //        return null;
        //    }
        //    return View(lt);
        //}

        [HttpGet]
        public ActionResult XoaLT(int id)
        {
            LOAI_TIN lt = data.LOAI_TINs.SingleOrDefault(n => n.MA_LOAI_TT == id);
            ViewBag.MA_LOAI_TT = lt.MA_LOAI_TT;
            if (lt == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(lt);
        }
        [HttpPost, ActionName("XoaLT")]
        public ActionResult XacnhanxoaLT(int id)
        {
            LOAI_TIN lt = data.LOAI_TINs.SingleOrDefault(n => n.MA_LOAI_TT == id);
            ViewBag.MA_LOAI_TT = lt.MA_LOAI_TT;
            if (lt == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.LOAI_TINs.DeleteOnSubmit(lt);
            data.SubmitChanges();
            return RedirectToAction("LoaiTinTuc");
        }
        [HttpGet]
        public ActionResult SuaLT(int id)
        {
            var lt = data.LOAI_TINs.First(n => n.MA_LOAI_TT == id);
            return View(lt);
        }
        [HttpPost]
        public ActionResult SuaLT(int id, FormCollection collection)
        {
            var lt = data.LOAI_TINs.First(n => n.MA_LOAI_TT == id);
            var tenlt = collection["TEN_LOAI_TT"];
            lt.MA_LOAI_TT = id;
            lt.TEN_LOAI_TT = tenlt;
            UpdateModel(lt);
            data.SubmitChanges();
            return RedirectToAction("Loaitin");
        }

        [HttpGet]
        public ActionResult ThemTK()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemTK(TAI_KHOAN tk)
        {
            data.TAI_KHOANs.InsertOnSubmit(tk);
            data.SubmitChanges();
            return RedirectToAction("TaiKhoan");
        }

        public ActionResult ChitietTK(int id)
        {
            TAI_KHOAN tk = data.TAI_KHOANs.SingleOrDefault(n => n.MATK == id);
            ViewBag.MATK = tk.MATK;
            if (tk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tk);
        }


        [HttpGet]
        public ActionResult XoaTK(int id)
        {
            TAI_KHOAN tk = data.TAI_KHOANs.SingleOrDefault(n => n.MATK == id);
            ViewBag.MATK = tk.MATK;
            if (tk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tk);
        }
        [HttpPost, ActionName("XoaTK")]
        public ActionResult Xacnhanxoatk(int id)
        {
            TAI_KHOAN tk = data.TAI_KHOANs.SingleOrDefault(n => n.MATK == id);
            ViewBag.MATK = tk.MATK;
            if (tk == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.TAI_KHOANs.DeleteOnSubmit(tk);
            data.SubmitChanges();
            return RedirectToAction("TaiKhoan");
        }

        [HttpGet]
        public ActionResult SuaTK(int id)
        {
            var tk = data.TAI_KHOANs.First(n => n.MATK == id);
            return View(tk);
        }
        [HttpPost]
        public ActionResult SuaTK(int id, FormCollection collection)
        {
            var tk = data.TAI_KHOANs.First(n => n.MATK == id);
            var ten = collection["TEN_TAI_KHOAN"];
            var mk = collection["MAT_KHAU"];
            tk.TEN_TAI_KHOAN = ten;
            tk.MAT_KHAU = mk;
            UpdateModel(tk);
            data.SubmitChanges();
            return RedirectToAction("TaiKhoan");
        }


        [HttpGet]
        public ActionResult ThemKH()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemKH(KHACH_HANG kh)
        {
            data.KHACH_HANGs.InsertOnSubmit(kh);
            data.SubmitChanges();
            return RedirectToAction("user");
        }

        [HttpGet]
        public ActionResult XoaKH(int id)
        {
            KHACH_HANG KH = data.KHACH_HANGs.SingleOrDefault(n => n.MAKH == id);
            ViewBag.MAKH = KH.MAKH;
            if (KH == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(KH);
        }
        [HttpPost, ActionName("XoaKH")]
        public ActionResult XacnhanxoaKH(int id)
        {
            KHACH_HANG kh = data.KHACH_HANGs.SingleOrDefault(n => n.MAKH == id);
            ViewBag.MAKH = kh.MAKH;
            if (kh == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.KHACH_HANGs.DeleteOnSubmit(kh);
            data.SubmitChanges();
            return RedirectToAction("user");
        }


        [HttpGet]
        public ActionResult SuaKH(int id)
        {
            var kh = data.KHACH_HANGs.First(n => n.MAKH == id);
            return View(kh);
        }
        [HttpPost]
        public ActionResult SuaKH(int id, FormCollection collection)
        {
            var KH = data.KHACH_HANGs.First(n => n.MAKH == id);
            var ten = collection["TENTK"];
            var mk = collection["MATKHAU"];
            var hoten = collection["HOTEN"];
            var dc = collection["DIACHI"];
            var dt = collection["DIENTHOAI"];
            var mail = collection["EMAIL"];
            KH.TENTK = ten;
            KH.MATKHAU = mk;
            KH.HOTEN = hoten;
            KH.DIACHI = dc;
            KH.DIENTHOAI = dt;
            KH.EMAIL = mail;
            UpdateModel(KH);
            data.SubmitChanges();
            return RedirectToAction("user");
        }

    }
}