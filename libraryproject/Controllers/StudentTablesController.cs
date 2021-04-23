﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using libraryproject;
using libraryproject.FactoryManager;
using libraryproject.FactoryMethod;
using libraryproject.filters;
using libraryproject.Logger;

namespace libraryproject.Controllers
{
    [Authorize]
    [AuthorizedUser]
    public class StudentTablesController : BaseController
    {
       
        private library_management_systemEntities1 db = new library_management_systemEntities1();

        
                
        // GET: StudentTables
        public ActionResult Index()
        {
            var studentTables = db.StudentTables.Include(s => s.DepartmentTable).Include(s => s.StudentTypeTable);
            return View(studentTables.ToList());
        }

        // GET: StudentTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudentTables.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            return View(studentTable);
        }

        // GET: StudentTables/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name");
            ViewBag.StuentTypeID = new SelectList(db.StudentTypeTables, "StudentTypeID", "StudentType");
            return View();
        }

        // POST: StudentTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,StudentName,StuentTypeID,DepartmentID,IsActive")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                StudentFactoryManager studfactory = new StudentFactoryManager();
                IStudentManger studManager = studfactory.GetStudentManager(studentTable.StuentTypeID);
               ViewBag.Getbook= studManager.GetBooks();
             ViewBag.GetDays= studManager.GetDays();

                db.StudentTables.Add(studentTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", studentTable.DepartmentID);
            ViewBag.StuentTypeID = new SelectList(db.StudentTypeTables, "StudentTypeID", "StudentType", studentTable.StuentTypeID);
            return View(studentTable);
        }

        // GET: StudentTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentTable studentTable = db.StudentTables.Find(id);
            if (studentTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", studentTable.DepartmentID);
            ViewBag.StuentTypeID = new SelectList(db.StudentTypeTables, "StudentTypeID", "StudentType", studentTable.StuentTypeID);
            return View(studentTable);
        }

        // POST: StudentTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,StudentName,StuentTypeID,DepartmentID,IsActive")] StudentTable studentTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.DepartmentTables, "DepartmentID", "Name", studentTable.DepartmentID);
            ViewBag.StuentTypeID = new SelectList(db.StudentTypeTables, "StudentTypeID", "StudentType", studentTable.StuentTypeID);
            return View(studentTable);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            var studentt = await db.StudentTables.FindAsync(id);
            db.StudentTables.Remove(studentt);
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


        // GET: StudentTables/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    StudentTable studentTable = db.StudentTables.Find(id);
        //    if (studentTable == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(studentTable);
        //}

        //// POST: StudentTables/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    StudentTable studentTable = db.StudentTables.Find(id);
        //    db.StudentTables.Remove(studentTable);
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
