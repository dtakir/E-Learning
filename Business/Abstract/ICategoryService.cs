using Core.Utilities.Result;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        IDataResult<List<Category>> GetListByParentCategory(int parentId);
        IResult  Add(Category category);
        IResult  Update(Category category);
        IResult  Delete(Category category);
    }
}
