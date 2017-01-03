using System;
using System.Linq;
using System.Web.Mvc;
using weptintuc.Models;

namespace weptintuc.Controllers
{
    public class NguoiDungController : Controller
    {
        dbNewsDataContext db = new dbNewsDataContext();
        //
        // GET: /NguoiDung/
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangky(FormCollection collection, KHACH_HANG tk)
        {
            var hoten = collection["HoTen"];
            var tendn = collection["TenDN"];
            var matkhau = collection["MatKhau"];
            var matkhaunhaplai = collection["MatKhauNL"];
            var email = collection["Email"];

            var diachi = collection["DiaChi"];
            var dienthoai = collection["DienThoai"];
            var ngaysinh = string.Format("{0:MM/đ/yyyy}", collection["Ngaysinh"]);
            if(string.IsNullOrEmpty(hoten))
            {
                ViewData["loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if (string.IsNullOrEmpty(tendn))
            {
                ViewData["loi2"] = "Tên đăng nhập không được để trống";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["loi3"] = "Mật khẩu không được để trống";
            }
            else if (string.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["loi4"] = "Mật khẩu không được để trống";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["loi5"] = "Email không được để trống";
            }
            else if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["loi6"] = "Điện thoại không được để trống";
            }
            else 
            {
                tk.HOTEN = hoten;
                tk.TENTK = tendn;
                tk.MATKHAU = matkhau;
                tk.EMAIL = email;
                tk.DIACHI= diachi;
                tk.DIENTHOAI = dienthoai;
                tk.NGAYSINH = DateTime.Parse(ngaysinh);
                db.KHACH_HANGs.InsertOnSubmit(tk);
                db.SubmitChanges();
                return RedirectToAction("Dangnhap");

            }
            return this.Dangky();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                KHACH_HANG tk = db.KHACH_HANGs.SingleOrDefault(n => n.TENTK == tendn && n.MATKHAU == matkhau);   
                if (tk!=null){
                    ViewBag.Thongbao = "Đăng nhập thành công";
                    Session["Taikhoan"] = tk;
                    return RedirectToAction("Index", "Home");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
        public ActionResult Dangxuat(FormCollection f)
        {
            Session["Taikhoan"] = null;
            return RedirectToAction("Index","Home");
        }

        public ActionResult TaiKhoan(int id)
        {
            var tk = from s in db.KHACH_HANGs
                      where s.MAKH == id
                      select s;
            return View(tk.Single());
        }

        [HttpGet]
        public ActionResult Suataikhoan(int id)
        {
            var kh = db.KHACH_HANGs.First(n => n.MAKH == id);
            return View(kh);
        }
        [HttpPost]
        public ActionResult Suataikhoan(int id, FormCollection collection)
        {
            var kh = db.KHACH_HANGs.First(n => n.MAKH == id);
            var hoten = collection["HOTEN"];
            var tentk = collection["TENTK"];
            var matkhau = collection["MATKHAU"];
            var email = collection["EMAIL"];

            var diachi = collection["DIACHI"];
            var dienthoai = collection["DIENTHOAI"];
            var ngaysinh = string.Format("{0:MM/dd/yyyy}", collection["NGAYSINH"]);
            if (string.IsNullOrEmpty(hoten))
            {
                ViewData["loi1"] = "Họ tên khách hàng không được để trống";
            }

            else if (String.IsNullOrEmpty(email))
            {
                ViewData["loi5"] = "Email không được để trống";
            }
            else if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["loi6"] = "Điện thoại không được để trống";
            }
            else
            {
                kh.HOTEN = hoten;
                kh.TENTK = tentk;
                kh.MATKHAU = matkhau;
                kh.EMAIL = email;
                kh.DIACHI = diachi;
                kh.DIENTHOAI = dienthoai;
                kh.NGAYSINH = DateTime.Parse(ngaysinh);
                UpdateModel(kh);
                db.SubmitChanges();
                //return RedirectToAction("Taikhoan");
            }
            return RedirectToAction("Taikhoan");
        }
	}
}