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
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<Instructor> GetById(int instructorId)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(i => i.Id == instructorId));
        }

        public IDataResult<List<Instructor>> GetList()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetList());
        }

        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.Updated);

        }
    }
}
