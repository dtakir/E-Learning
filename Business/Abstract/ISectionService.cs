using Core.Utilities.Result;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISectionService
    {
        IDataResult<Section> GetById(int sectionId);
        IDataResult<List<Section>> GetList();
        IResult Add(Section section);
        IResult Update(Section section);
        IResult Delete(Section section);
    }
}
