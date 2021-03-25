using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using libraryproject;
using libraryproject.filters;

namespace libraryproject.Controllers
{
    [Authorize]
    [AuthorizedUser]
    public class BookTablesController : Controller
    {
        private library_management_systemEntities1 db = new library_management_systemEntities1();

        // GET: BookTables
        public ActionResult Index()
        {
            var bookTables = db.BookTables.Include(b => b.BookTypeTable).Include(b => b.DepartmentTable);
            return View(bookTables.ToList());
        }

        // GET: BookTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookTable bookTable = db.BookTables.Find(id);
            if (bookTable == null)
            {
                return HttpNotFound();
            }
            return View(bookTable);
        }

        // GET: BookTables/Create
        public ActionResult Create()
        {
            ViewBag.BookTypeID = new SelectList(db.BookTypeTables, "BookTypeID", "Name");
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name");
            return View();
        }

        // POST: BookTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookID,DepartmentID,BookTypeID,BookTitle,Author,BookName,Edition,TotalCopies,RegDate,Price,Description")] BookTable bookTable)
        {
            if (ModelState.IsValid)
            {
                db.BookTables.Add(bookTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookTypeID = new SelectList(db.BookTypeTables, "BookTypeID", "Name", bookTable.BookTypeID);
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", bookTable.DepartmentID);
            return View(bookTable);
        }

        // GET: BookTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookTable bookTable = db.BookTables.Find(id);
            if (bookTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookTypeID = new SelectList(db.BookTypeTables, "BookTypeID", "Name", bookTable.BookTypeID);
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", bookTable.DepartmentID);
            return View(bookTable);
        }

        // POST: BookTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookID,DepartmentID,BookTypeID,BookTitle,Author,BookName,Edition,TotalCopies,RegDate,Price,Description")] BookTable bookTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookTypeID = new SelectList(db.BookTypeTables, "BookTypeID", "Name", bookTable.BookTypeID);
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", bookTable.DepartmentID);
            return View(bookTable);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            var book = await db.BookTables.FindAsync(id);
            db.BookTables.Remove(book);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            //if (id == null || id == 0)
            //{
            //    return NotFound();
            //}
            //var obj = _db.Categary.Find(id);
            //if (obj == null)
            //{
            //    return NotFound();
            //}

            //return View(obj);
        }


        // GET: BookTables/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    BookTable bookTable = db.BookTables.Find(id);
        //    if (bookTable == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(bookTable);
        //}

        //// POST: BookTables/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    BookTable bookTable = db.BookTables.Find(id);
        //    db.BookTables.Remove(bookTable);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
