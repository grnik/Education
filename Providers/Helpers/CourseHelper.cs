using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using DataModel;

namespace Providers
{

    public class CourseHelper : IModelHelper<Course>
    {
        public Course GetById(Guid id)
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                DataModel.Course appType = context.Courses.FirstOrDefault(a => a.ID == id);

                return Translate(appType);
            }
        }

        public List<Course> GetByName(string name)
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                List<Course> list = new List<Course>();

                foreach (var elem in context.Courses.Where(c => c.Name.Contains(name)))
                {
                    list.Add(Translate(elem));
                }
                return list;
            }
        }

        public List<Course> GetAll()
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                List<Course> list = new List<Course>();

                foreach (var elem in context.Courses)
                {
                    list.Add(Translate(elem));
                }
                return list;
            }
        }

        Course Translate(DataRow data)
        {
            Course newCourse = new Course();

            newCourse.ID = (Guid)(data["ID"]);
            newCourse.Name = data["Name"].ToString();

            return newCourse;
        }

        Course Translate(DataModel.Course course)
        {
            Course newCourse = new Course();

            newCourse.ID = course.ID;
            newCourse.Name = course.Name;

            return newCourse;
        }

        public void Save(Course elem)
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                DataModel.Course course = context.Courses.FirstOrDefault(a => a.ID == elem.ID);
                if (course == null)
                {
                    course = new DataModel.Course();
                    course.ID = Guid.NewGuid();
                }
                course.Name = elem.Name;

                context.SaveChanges();
            }
        }
    }
}
