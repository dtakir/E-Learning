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
    public class EfCurriculumDal : EfEntityFrameworkBase<Curriculum, ELearningContext>, ICurriculumDal
    {
        public List<Curriculum> GetListByCourse(int courseId)
        {
            using (var context=new ELearningContext())
            {
                var result = from curriculum in context.Curricullums
                             join courseCurriculum in context.CourseCurriculums
                             on curriculum.Id equals courseCurriculum.CurriculumId
                             join course in context.Courses
                             on courseCurriculum.CourseId equals course.Id
                             where courseCurriculum.CourseId == courseId
                             select new Curriculum { Duration = curriculum.Duration, SectionId = curriculum.SectionId, Name = curriculum.Name, Id = curriculum.Id };
                return result.ToList();
            }
        }
    }
}
