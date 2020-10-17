using Core.Utilities.Result;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetList();
        IDataResult<Course> GetById(int courseId);
        IDataResult<List<Course>> GetListByCategory(int categoryId);
        IDataResult<List<Course>> GetListByInstructor(int instructorId);
        
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
    }
}
