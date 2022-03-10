using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class AcademicPlansController : Controller
    {
        private UsersContext db = new UsersContext();

        // GET: AcademicPlans
        public async Task<ActionResult> Index()
        {
            return View(await db.AcademicPlans.ToListAsync());
        }

        // GET: AcademicPlans/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicPlan academicPlan = await db.AcademicPlans.FindAsync(id);
            if (academicPlan == null)
            {
                return HttpNotFound();
            }
            return View(academicPlan);
        }

        // GET: AcademicPlans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcademicPlans/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AcademicPlanId,PlanName")] AcademicPlan academicPlan)
        {
            if (ModelState.IsValid)
            {
                db.AcademicPlans.Add(academicPlan);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(academicPlan);
        }

        // GET: AcademicPlans/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicPlan academicPlan = await db.AcademicPlans.FindAsync(id);
            if (academicPlan == null)
            {
                return HttpNotFound();
            }
            return View(academicPlan);
        }

        // POST: AcademicPlans/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AcademicPlanId,PlanName")] AcademicPlan academicPlan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academicPlan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(academicPlan);
        }

        // GET: AcademicPlans/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AcademicPlan academicPlan = await db.AcademicPlans.FindAsync(id);
            if (academicPlan == null)
            {
                return HttpNotFound();
            }
            return View(academicPlan);
        }

        // POST: AcademicPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            AcademicPlan academicPlan = await db.AcademicPlans.FindAsync(id);
            db.AcademicPlans.Remove(academicPlan);
            await db.SaveChangesAsync();
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
