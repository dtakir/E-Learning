using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework.Context;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfInstructorDal: EfEntityFrameworkBase<Instructor,ELearningContext>,IInstructorDal
    {
    }
}
