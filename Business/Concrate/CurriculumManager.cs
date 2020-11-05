using Business.Abstract;
using Business.Constands;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CurriculumManager : ICurriculumService
    {
        private readonly ICurriculumDal _curriculumDal;
        public CurriculumManager(ICurriculumDal curriculumDal)
        {
            _curriculumDal = curriculumDal;
        }

        [ValidationAspect(typeof(CurriculumValidator))]
        public IResult Add(Curriculum curriculum)
        {
            _curriculumDal.Add(curriculum);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Curriculum curriculum)
        {
            _curriculumDal.Delete(curriculum);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Curriculum>> GetListByCourse(int courseId)
        {
            return new SuccessDataResult<List<Curriculum>>(_curriculumDal.GetListByCourse(courseId));
        }

        [ValidationAspect(typeof(CurriculumValidator))]
        public IResult Update(Curriculum curriculum)
        {
            _curriculumDal.Update(curriculum);
            return new SuccessResult(Messages.Updated);

        }
    }
}
