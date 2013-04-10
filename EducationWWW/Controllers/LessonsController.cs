using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Providers;

namespace EducationWWW.Controllers
{
    public class LessonsController : Controller
    {
        LessonHelper lessonHelper = new LessonHelper();
        //
        // GET: /Lessons/

        public ActionResult Index(Guid courseID)
        {
            return View(lessonHelper.GetByCourse(courseID));
        }

        [AcceptVerbs("GET")]
        public ActionResult Edit(string ID)
        {
            return this.View(lessonHelper.GetById(new Guid(ID)));
        }

        [AcceptVerbs("POST")]
        public ActionResult Edit(Lesson lesson)
        {
            if (lesson.IsValid())
            {
                Lesson readLesson = lessonHelper.GetById(lesson.ID);
                if(readLesson != null)
                {
                    lesson.App = readLesson.App;
                    lesson.AppType = readLesson.AppType;
                    lesson.Course = readLesson.Course;
                }
                lessonHelper.Save(lesson);
                return RedirectToAction("Index", new { courseID = lesson.Course.ID });
            }
            else
            {
                ModelState.AddModelError("ID", "Надо заполнить.");
                return this.View(lesson);
            }
        }

        public ActionResult Details(string ID)
        {
            return View(lessonHelper.GetById(new Guid(ID)));
        }
    }
}
