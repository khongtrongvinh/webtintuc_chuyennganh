
using System.Web.Mvc;
using weptintuc.Models;
namespace weptintuc.Controllers
{
    public class SendMailController : Controller
    {
        //
        // GET: /SendMail/

        public ActionResult sendmail()
        {
            var model = new Lienhemodel();
            return View(model);
        }
        [HttpPost]
        public ActionResult sendmail(Lienhemodel model)
        {
            if (ModelState.IsValid)
            {
                string smtpUserName = "acex123456789@gmail.com";
                string smtpPassword = "khongtrongvinh123";
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 25;

                string emailTo = "acex123456789@gmail.com"; // Khi có liên hệ sẽ gửi về thư của mình
                string subject = model.Subject;
                string body = string.Format("Bạn vừa nhận được liên hệ từ: <b>{0}</b><br/>Email: {1}<br/>Nội dung: </br>{2}",
                    model.UserName, model.Email, model.Message);

                EmailService service = new EmailService();

                bool kq = service.Send(smtpUserName, smtpPassword, smtpHost, smtpPort,
                    emailTo, subject, body);

                if (kq) ModelState.AddModelError("", "Cảm ơn bạn đã liên hệ với chúng tôi.");
                else ModelState.AddModelError("", "Gửi tin nhắn thất bại, vui lòng thử lại.");
            }
            return View(model);
        }
    }
}
