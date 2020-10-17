using Business.Abstract;
using Business.Constands;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SectionManager : ISectionService
    {
        private readonly ISectionDal _sectionDal;
        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }
        public IResult Add(Section section)
        {
            _sectionDal.Add(section);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Section section)
        {
            _sectionDal.Delete(section);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<Section> GetById(int sectionId)
        {
            return new SuccessDataResult<Section>(_sectionDal.Get(s => s.Id == sectionId));
        }

        public IDataResult<List<Section>> GetList()
        {
            return new SuccessDataResult<List<Section>>(_sectionDal.GetList());
        }

        public IResult Update(Section section)
        {
            _sectionDal.Update(section);
            return new SuccessResult(Messages.Updated);

        }
    }
}
