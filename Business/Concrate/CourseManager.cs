using Business.Abstract;
using Business.Constands;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrate
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;

        }
        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<Course> GetById(int courseId)
        {
            return new SuccessDataResult<Course>( _courseDal.Get(c=>c.Id==courseId));
        }

        public IDataResult<List<Course>> GetList()
        {
            return new SuccessDataResult<List<Course>>( _courseDal.GetList().ToList());
        }

        public IDataResult<List<Course>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetListByCategory(categoryId));
        }

        public IDataResult<List<Course>> GetListByInstructor(int instructorId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetListByInstructor(instructorId));

        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);

        }
    }
}
