using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using ekscarMVC.Models;
using ekscarMVC.Models.Maintenance;

namespace ekscarMVC.Controllers
{
    public class MaintenancesController : Controller
    {
        private Base db = new Base();

        // GET: Maintenances
        public ActionResult Index()
        {
            var maintenance = db.Maintenance.Include(m => m.City).Include(m => m.Region).Include(m => m.Model).Include(m => m.Brand).Include(m => m.Fuel).Include(m => m.Gear).Include(m => m.Type).Where(m=>m.CityId==1 && m.Region.CityId ==1);
            return View(maintenance.ToList());
        }

        // GET: Maintenances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = db.Maintenance.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        // GET: Maintenances/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.City, "Id", "Name",1);
            ViewBag.RegionId = new SelectList(db.Region.Where(m=>m.CityId==1), "Id", "Name");
            ViewBag.BrandId = new SelectList(db.CarBrand, "Id", "Name");       
            ViewBag.FuelId = new SelectList(db.CarFuelType, "Id", "Name");
            ViewBag.GearId = new SelectList(db.CarGearType, "Id", "Name");
            ViewBag.ModelId = new SelectList(db.CarModel, "Id", "Name");
            ViewBag.TypeId = new SelectList(db.CarType, "Id", "Name");
            return View();
        }

        // POST: Maintenances/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CityId,RegionId,BrandId,ModelId,TypeId,Year,GearId,FuelId,Description")] Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                db.Maintenance.Add(maintenance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.CarBrand, "Id", "Name", maintenance.BrandId);
            ViewBag.CityId = new SelectList(db.City, "Id", "Name", maintenance.CityId);
            ViewBag.FuelId = new SelectList(db.CarFuelType, "Id", "Name", maintenance.FuelId);
            ViewBag.GearId = new SelectList(db.CarGearType, "Id", "Name", maintenance.GearId);
            ViewBag.ModelId = new SelectList(db.CarModel, "Id", "Name", maintenance.ModelId);
            ViewBag.RegionId = new SelectList(db.Region, "Id", "Name", maintenance.RegionId);
            ViewBag.TypeId = new SelectList(db.CarType, "Id", "Name", maintenance.TypeId);
            return View(maintenance);
        }

        public JsonResult FetchRegion(int CityId)
        {
            List<SelectListItem> PList = new List<SelectListItem>();
            PList = db.Region.Where(m=>m.CityId == CityId).Select(i => new SelectListItem()
                     {
                         Text = i.Name,
                         Value = i.Id.ToString()
                     }).ToList();

            return Json(PList, JsonRequestBehavior.AllowGet);
        }

        // GET: Maintenances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = db.Maintenance.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandId = new SelectList(db.CarBrand, "Id", "Name", maintenance.BrandId);
            ViewBag.CityId = new SelectList(db.City, "Id", "Name", maintenance.CityId);
            ViewBag.FuelId = new SelectList(db.CarFuelType, "Id", "Name", maintenance.FuelId);
            ViewBag.GearId = new SelectList(db.CarGearType, "Id", "Name", maintenance.GearId);
            ViewBag.ModelId = new SelectList(db.CarModel, "Id", "Name", maintenance.ModelId);
            ViewBag.RegionId = new SelectList(db.Region, "Id", "Name", maintenance.RegionId);
            ViewBag.TypeId = new SelectList(db.CarType, "Id", "Name", maintenance.TypeId);
            return View(maintenance);
        }

        // POST: Maintenances/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CityId,RegionId,BrandId,ModelId,TypeId,Year,GearId,FuelId,Description")] Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maintenance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.CarBrand, "Id", "Name", maintenance.BrandId);
            ViewBag.CityId = new SelectList(db.City, "Id", "Name", maintenance.CityId);
            ViewBag.FuelId = new SelectList(db.CarFuelType, "Id", "Name", maintenance.FuelId);
            ViewBag.GearId = new SelectList(db.CarGearType, "Id", "Name", maintenance.GearId);
            ViewBag.ModelId = new SelectList(db.CarModel, "Id", "Name", maintenance.ModelId);
            ViewBag.RegionId = new SelectList(db.Region, "Id", "Name", maintenance.RegionId);
            ViewBag.TypeId = new SelectList(db.CarType, "Id", "Name", maintenance.TypeId);
            return View(maintenance);
        }

        // GET: Maintenances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maintenance maintenance = db.Maintenance.Find(id);
            if (maintenance == null)
            {
                return HttpNotFound();
            }
            return View(maintenance);
        }

        // POST: Maintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Maintenance maintenance = db.Maintenance.Find(id);
            db.Maintenance.Remove(maintenance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
