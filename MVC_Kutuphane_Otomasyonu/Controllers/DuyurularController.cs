using MVC_Kutuphane_Otomasyonu.Entities.DAL;
using MVC_Kutuphane_Otomasyonu.Entities.Model;
using MVC_Kutuphane_Otomasyonu.Entities.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVC_Kutuphane_Otomasyonu.Controllers
{
    public class DuyurularController : Controller
    {
        // GET: Duyurular

        KutuphaneContext context = new KutuphaneContext();
        DuyurularDAL duyurularDAL = new DuyurularDAL();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult DuyuruList()
        {
            var model = duyurularDAL.GetAll(context);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DuyuruEkle(Duyurular entity)
        {
            if (ModelState.IsValid)
            {
                duyurularDAL.InsertorUpdate(context, entity);
                duyurularDAL.Save(context);//veritabanına kaydediyor
                int newRecordId = entity.Id;


                return Json(new { recordId = newRecordId, success = true, message = "İşlem başarıyla gerçekleşti" }, JsonRequestBehavior.AllowGet);
            }
            var errors = ModelState.ToDictionary(
                x => x.Key,
                x => x.Value.Errors.Select(a => a.ErrorMessage).ToArray()
                );
            return Json(new { success = false, errors }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DuyuruGetir(int? Id)
        {
            var model = duyurularDAL.GetByFilter(context, x => x.Id == Id);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DuyuruSil(int id)
        {
            try
            {
                // İlgili Duyuru'yu veritabanından bulun
                Duyurular duyuru = context.Duyurular.Find(id);

                if (duyuru == null)
                {
                    return Json(new { success = false, message = "Duyuru bulunamadı." });
                }

                // Duyuruyu veritabanından silin
                context.Duyurular.Remove(duyuru);
                context.SaveChanges();

                return Json(new { success = true, message = "Duyuru başarıyla silindi." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Silme işlemi sırasında bir hata oluştu: " + ex.Message });
            }
        }
        [HttpPost]
        public JsonResult SeciliDuyuruSil(List<int> selectedIds)

        {
            if (selectedIds != null)
            {
                foreach (int id in selectedIds)
                {
                    duyurularDAL.Delete(context, x => x.Id == id);
                    duyurularDAL.Save(context);
                }


                return Json(new { success = true });
            }

        return Json(new { success = false });

        }
        
    }
}