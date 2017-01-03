using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using weptintuc.Models;
using PagedList;

namespace weptintuc.Controllers
{
    public class HomeController : Controller
    {
         dbNewsDataContext data = new dbNewsDataContext();

        private List<TIN_TUC> LayTinMoi()
        {
            return data.TIN_TUCs.OrderByDescending(n=>n.NGAY_DANG).ToList();
        }
        

       
        public ActionResult Index(int ? page)
        {
            
            int pageSize = 10;
            int pageNum = (page ?? 1);
            var tinmoi = LayTinMoi();
            return View(tinmoi.ToPagedList(pageNum, pageSize));
        }

        private List<TIN_TUC> TinWrapper(int count)
        {
            return data.TIN_TUCs.OrderByDescending(n => n.NGAY_DANG).Take(count).ToList();
        }

        public ActionResult Wrapper()
        {
            var wrapper = TinWrapper(4);
            return PartialView(wrapper);
        }

        private List<TIN_TUC> TinList(int count)
        {
            return data.TIN_TUCs.OrderBy(n => n.NGAY_DANG).Take(count).ToList();
        }

        public ActionResult List()
        {
            var wrapper = TinList(4);
            return PartialView(wrapper);
        }
        
        public ActionResult Chude()
        {
            var chude = from cd in data.LOAI_TINs select cd;
            return PartialView(chude);

        }
        
        
        public ActionResult Tintheochude(int id, int ? page)
        {
            var tin = from s in data.TIN_TUCs 
                      where s.MA_LOAI_TT == id
                      select s;
            int pageSize = 10;
            int pageNum = (page ?? 1);

            return View(tin.OrderByDescending(n=>n.NGAY_DANG).ToPagedList(pageNum, pageSize));
        }

        public ActionResult Chitiet(int id)
        {
            var tin = from s in data.TIN_TUCs
                      where s.MATT == id 
                      select s;    
            return View(tin.Single());
        }

        public ActionResult Timkiem(string txtname)
        {
            var lt = data.TIN_TUCs.Where(n => n.TEN_TT.Contains(txtname));
            return View(lt);
        }
    }
}