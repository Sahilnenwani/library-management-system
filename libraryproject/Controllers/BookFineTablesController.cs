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
    public class BookFineTablesController : Controller
    {
        
        private library_management_systemEntities1 db = new library_management_systemEntities1();

        // GET: BookFineTables
        public ActionResult Index()
        {
            var bookFineTables = db.BookFineTables.Include(b => b.BookTable).Include(b => b.StudentTable);
            return View(bookFineTables.ToList());
        }

        // GET: BookFineTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookFineTable bookFineTable = db.BookFineTables.Find(id);
            if (bookFineTable == null)
            {
                return HttpNotFound();
            }
            return View(bookFineTable);
        }

        // GET: BookFineTables/Create
        public ActionResult Create()
        {
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle");
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName");
            return View();
        }

        // POST: BookFineTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookFineID,BookID,StudentID,FineDate,FineAmount,NoOfDays")] BookFineTable bookFineTable)
        {
            if (ModelState.IsValid)
            {
                db.BookFineTables.Add(bookFineTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", bookFineTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", bookFineTable.StudentID);
            return View(bookFineTable);
        }

        // GET: BookFineTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookFineTable bookFineTable = db.BookFineTables.Find(id);
            if (bookFineTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", bookFineTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", bookFineTable.StudentID);
            return View(bookFineTable);
        }

        // POST: BookFineTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookFineID,BookID,StudentID,FineDate,FineAmount,NoOfDays")] BookFineTable bookFineTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookFineTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", bookFineTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", bookFineTable.StudentID);
            return View(bookFineTable);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            var bookfine = await db.BookFineTables.FindAsync(id);
            db.BookFineTables.Remove(bookfine);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }

        // GET: BookFineTables/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    BookFineTable bookFineTable = db.BookFineTables.Find(id);
        //    if (bookFineTable == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(bookFineTable);
        //}

        //// POST: BookFineTables/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    BookFineTable bookFineTable = db.BookFineTables.Find(id);
        //    db.BookFineTables.Remove(bookFineTable);
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
