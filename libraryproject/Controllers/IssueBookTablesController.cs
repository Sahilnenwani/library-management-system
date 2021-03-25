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
    public class IssueBookTablesController : Controller
    {
        private library_management_systemEntities1 db = new library_management_systemEntities1();

        // GET: IssueBookTables
        public ActionResult Index()
        {
            var issueBookTables = db.IssueBookTables.Include(i => i.BookTable).Include(i => i.StudentTable);
            return View(issueBookTables.ToList());
        }

        // GET: IssueBookTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IssueBookTable issueBookTable = db.IssueBookTables.Find(id);
            if (issueBookTable == null)
            {
                return HttpNotFound();
            }
            return View(issueBookTable);
        }

        // GET: IssueBookTables/Create
        public ActionResult Create()
        {
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle");
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName");
            return View();
        }

        // POST: IssueBookTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IssueBookID,StudentID,BookID,IssueCopies,IssueDate,ReturnDate,Status,Description")] IssueBookTable issueBookTable)
        {
            if (ModelState.IsValid)
            {
                db.IssueBookTables.Add(issueBookTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", issueBookTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", issueBookTable.StudentID);
            return View(issueBookTable);
        }

        // GET: IssueBookTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IssueBookTable issueBookTable = db.IssueBookTables.Find(id);
            if (issueBookTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", issueBookTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", issueBookTable.StudentID);
            return View(issueBookTable);
        }

        // POST: IssueBookTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IssueBookID,StudentID,BookID,IssueCopies,IssueDate,ReturnDate,Status,Description")] IssueBookTable issueBookTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(issueBookTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookID = new SelectList(db.BookTables, "BookID", "BookTitle", issueBookTable.BookID);
            ViewBag.StudentID = new SelectList(db.StudentTables, "StudentID", "StudentName", issueBookTable.StudentID);
            return View(issueBookTable);
        }

        // GET: IssueBookTables/Delete/5


        public async Task<ActionResult> Delete(int? id)
        {
            var bookissue = await db.IssueBookTables.FindAsync(id);
            db.IssueBookTables.Remove(bookissue);
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


        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    IssueBookTable issueBookTable = db.IssueBookTables.Find(id);
        //    if (issueBookTable == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(issueBookTable);
        //}

        //// POST: IssueBookTables/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    IssueBookTable issueBookTable = db.IssueBookTables.Find(id);
        //    db.IssueBookTables.Remove(issueBookTable);
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
