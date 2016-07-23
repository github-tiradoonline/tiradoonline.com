using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using tiradoonline.DataAccess.InterviewQuestionsAnswers;
using tiradoonline.DataAccess.InterviewQuestionsAnswers.Models;

namespace tiradoonline.InterviewQuestionsAnswers.Controllers
{
    public class AnswersController : Controller
    {
        private InterviewQuestionsAnswersContext db = new InterviewQuestionsAnswersContext();

        // GET: Answers
        public ActionResult Index()
        {
            var answers = db.Answers.Include(a => a.Questions);
            return View(answers.ToList());
        }

        // GET: Answers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answers answers = db.Answers.Find(id);
            if (answers == null)
            {
                return HttpNotFound();
            }
            return View(answers);
        }

        // GET: Answers/Create
        public ActionResult Create()
        {
            ViewBag.QuestionID = new SelectList(db.Questions, "QuestionID", "Question");
            return View();
        }

        // POST: Answers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnswerID,QuestionID,Answer,create_dt")] Answers answers)
        {
            if (ModelState.IsValid)
            {
                db.Answers.Add(answers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestionID = new SelectList(db.Questions, "QuestionID", "Question", answers.QuestionID);
            return View(answers);
        }

        // GET: Answers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answers answers = db.Answers.Find(id);
            if (answers == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestionID = new SelectList(db.Questions, "QuestionID", "Question", answers.QuestionID);
            return View(answers);
        }

        // POST: Answers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnswerID,QuestionID,Answer,create_dt")] Answers answers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.QuestionID = new SelectList(db.Questions, "QuestionID", "Question", answers.QuestionID);
            return View(answers);
        }

        // GET: Answers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answers answers = db.Answers.Find(id);
            if (answers == null)
            {
                return HttpNotFound();
            }
            return View(answers);
        }

        // POST: Answers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Answers answers = db.Answers.Find(id);
            db.Answers.Remove(answers);
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
