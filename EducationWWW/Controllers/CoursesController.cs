using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationWWW.Controllers
{
    using Providers;

    public class CoursesController : Controller
    {
        CourseHelper courseHelper = new CourseHelper();
        //
        // GET: /Courses/

        public ActionResult Index(string Course)
        {
            if (String.IsNullOrEmpty(Course))
                return View(courseHelper.GetAll());
            else
            {
                //string search = HttpUtility.UrlDecode(Course, new UTF8Encoding());
                //search = HttpUtility.HtmlDecode(Course);
                //search = HttpUtility.HtmlEncode(Course);
                //search = HttpUtility.UrlEncode(Course);
                //search = DecodingSearch(Course);
                //search = UndecodingSearch(Course);
                //search = System.Text.Encoding.
                return this.View(courseHelper.GetByName(HttpUtility.HtmlDecode(Course)));
            }
        }

        public ActionResult Detail(string ID)
        {
            return this.View(courseHelper.GetById(new Guid(ID)));
        }

        [AcceptVerbs("GET")]
        public ActionResult Edit(string ID)
        {
            return this.View(courseHelper.GetById(new Guid(ID)));
        }

        [AcceptVerbs("POST")]
        public ActionResult Edit(Course course)
        {
            if(course.IsValid())
            {
                courseHelper.Save(course);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("ID", "Надо заполнить.");
                return this.View(course);
            }
        }
    }
}
