using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace UILayer.Controllers
{
    public class NewLetterController : Controller
    {

        NewLetterManager nlM = new NewLetterManager(new EfNewLetterRepository());
        [HttpGet]
        public PartialViewResult SubScribMail()
        {
            return PartialView();
        }
        //AddOrUpdateAppoinment
        // SubScribMail

        [HttpPost]
        public JsonResult SubScribMail(string Mail)
        {

            NewsLetter nL = new NewsLetter()
            {
                Mail = Mail,
                CreateDate = System.DateTime.Now,
                Status = true
            };

            

            nlM.LetterAdd(nL);
            return Json(nL);
            //Validasyon
            //if (model.Id == 0)
            //{
            //    Appointment entity = new Appointment()
            //    {
            //        CreatedDate = DateTime.Now,
            //        StartDate = model.StartDate,
            //        EndDate = model.EndDate,
            //        PatientName = model.PatientName,
            //        PatientSurname = model.PatientSurname,
            //        Description = model.Description,
            //        UserId = model.UserId
            //    };

            //    _context.Add(entity);
            //    _context.SaveChanges();
            //}
            //else
            //{
            //    var entity = _context.Appointments.SingleOrDefault(x => x.Id == model.Id);
            //    if (entity == null)
            //    {
            //        return Json("Güncellenecek veri bulunamadı.");
            //    }
            //    entity.UpdatedDate = DateTime.Now;
            //    entity.PatientName = model.PatientName;
            //    entity.PatientSurname = model.PatientSurname;
            //    entity.Description = model.Description;
            //    entity.StartDate = model.StartDate;
            //    entity.EndDate = model.EndDate;
            //    entity.UserId = model.UserId;

            //    _context.Update(entity);
            //    _context.SaveChanges();
            //}

            //return Json("200");
        }

        //[HttpPost]
        //public JsonResult SubScribMail(NewsLetter p)
        //{
        //    p.CreateDate = System.DateTime.Now;
        //    p.Status = true;
        //    nlM.LetterAdd(p);
        //    return Json(p);
        //}
        //    NewLetterValidator valida = new NewLetterValidator();

        //    ValidationResult result = valida.Validate(p);
        //    if (result.IsValid)
        //    {
        //        p.Status = true;
        //        p.CreateDate = System.DateTime.Now;
        //        nlM.LetterAdd(p);
        //        return RedirectToAction("Index", "Blog");
        //    }
        //    else
        //    {
        //        foreach (var item in result.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();



        //}
    }
}
