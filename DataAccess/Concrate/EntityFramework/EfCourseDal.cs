using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCourseDal : EfEntityFrameworkBase<Course, ELearningContext>, ICourseDal
    {
        public List<Course> GetListByCategory(int categoryId)
        {
            using (var context = new ELearningContext())
            {
                var result = from course in context.Courses
                             join courseCategory in context.CourseCategories
                             on course.Id equals courseCategory.CourseId
                             join category in context.Categories
                             on courseCategory.CategoryId equals category.Id
                             where courseCategory.Id == categoryId
                             select new Course { Id = course.Id, Name = course.Name, Description = course.Description, CreatedDate = course.CreatedDate, Price = course.Price };
                return result.ToList();
            }

        }

        public List<Course> GetListByInstructor(int instructorId)
        {
            using (var context = new ELearningContext())
            {
                var result = from course in context.Courses
                             join userCourse in context.UserCourses
                             on course.Id equals userCourse.CourseId
                             join user in context.Users
                             on userCourse.UserId equals user.Id
                             where user.Id == instructorId
                             select new Course { Id = course.Id, Name = course.Name, Description = course.Description, CreatedDate = course.CreatedDate, Price = course.Price };
                return result.ToList();
            }
        }
    }
}
