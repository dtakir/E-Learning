﻿using Core.DataAccess;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICurriculumDal : IEntityRepository<Curriculum>
    {
        List<Curriculum> GetListByCourse(int courseId);
    }
}