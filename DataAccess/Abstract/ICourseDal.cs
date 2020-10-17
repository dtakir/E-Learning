using Core.DataAccess;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICourseDal : IEntityRepository<Course>
    {
        List<Course> GetListByCategory(int categoryId);
        List<Course> GetListByInstructor(int instructorId);
    }
}
