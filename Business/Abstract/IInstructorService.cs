using Core.Utilities.Result;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetList();
        IDataResult<Instructor> GetById(int instructorId);
        IResult Add(Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
    }
}
