using MVC_Kutuphane_Otomasonu.Entities.DAL;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using MVC_Kutuphane_Otomasyonu.Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Kutuphane_Otomasyonu.Controllers
{
    public class KullanicilarController : Controller
    {
        // GET: Kullanicilar
        KutuphaneContext context= new KutuphaneContext();
        KullanicilarDAL kullanicilarDAL=new KullanicilarDAL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Kullanicilar entity) 
        {
            if(User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
            }
            var model = kullanicilarDAL.GetByFilter(context, x => x.Email == entity.Email && x.Sifre == entity.Sifre);
            if(model != null) 
            {
                FormsAuthentication.SetAuthCookie(entity.Email, false);
                return RedirectToAction("Index2", "KitapTurleri");
            }
             
            ViewBag.error = "Kullanıcı adı veya şifre yanlış";
            return View();
     

        }
        public ActionResult KayitOl()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]

        public ActionResult KayitOl(Kullanicilar entity, string sifreTekrar, bool kabul)
        {
            if (!ModelState.IsValid) //Model doğrulanmazsa
            {
                return View(entity);
            }
            else //Model doğrulama
            {
                if (entity.Sifre != sifreTekrar) //Şifreler uyuşmuyorsa
                {
                    ViewBag.sifreError = "Girdiğiniz şifreler uyuşmuyor";
                    return View();
                }
                else //Şifreler uyuşuyorsa
                {
                    if(!kabul) //Şartlar kabul edilmemişse
                    {
                        ViewBag.kabulError = "Lütfen şartları kabul ettiğinizi onaylayın!";
                        return View();
                    }
                    else //Şartlar kabul edilmişse
                    {
                        entity.KayitTarihi = DateTime.Now;
                        kullanicilarDAL.InsertorUpdate(context, entity);
                        kullanicilarDAL.Save(context);
                        return RedirectToAction("Login");
                    }
                }
            }
             
        }

        public ActionResult SifremiUnuttum()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [ HttpPost]
        public ActionResult SifremiUnuttum(Kullanicilar entity)
        {

            var model = kullanicilarDAL.GetByFilter(context, x => x.Email == entity.Email);
            if (model != null)
            {
                Guid rastgele = Guid.NewGuid();
                model.Sifre = rastgele.ToString().Substring(0, 8);
                kullanicilarDAL.Save(context);
                SmtpClient client = new SmtpClient("smtp.outlook.com", 587);
                client.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rumeysa.yesil@istanbulticaret.edu.tr", "Şifre sıfırlama");
                mail.To.Add(model.Email);
                mail.IsBodyHtml = true;
                mail.Subject = "Şifre Değiştirme İsteği";
                mail.Body += "Merhaba " + model.AdiSoyadi + "<br/> Kullanıcı Adınız=" + model.KullaniciAdi + "<br/> Şifreniz=" + model.Sifre;
                NetworkCredential net = new NetworkCredential("rumeysa.yesil@istanbulticaret.edu.tr", "sifre1234");
                client.Credentials = net;
                client.Send(mail);
                return RedirectToAction("Login");
            }
            else if (model == null && entity.Email != null)
            {
                ViewBag.hata = "Böyle bir e-mail adresi bulunamadı.";
                return View();
            }

            return View();
        }
    }
}