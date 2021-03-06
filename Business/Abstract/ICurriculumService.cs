﻿using Core.Utilities.Result;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICurriculumService
    {
        IDataResult<List<Curriculum>> GetListByCourse(int courseId);
        IResult Add(Curriculum curriculum);
        IResult Update(Curriculum curriculum);
        IResult Delete(Curriculum curriculum);
    }
}
