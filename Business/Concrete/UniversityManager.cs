using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UniversityManager : IUniversityService
    {
        IUniversityDal _universityDal;

        public UniversityManager(IUniversityDal universityDal)
        {
            _universityDal = universityDal;
        }

        public IResult Add(University university)
        {
            return new SuccessResult();
            _universityDal.Add(university);
        }

        public IResult Delete(University university)
        {
            return new SuccessResult();
            _universityDal.Delete(university);
        }

        public IDataResult<List<University>> GetAll()
        {
            return new SuccessDataResult<List<University>>(_universityDal.GetList());
        }

        public IDataResult<University> GetByUniversityId(int UniverstiyId)
        {
            return new SuccessDataResult<University>(_universityDal.Get(u => u.Id == UniverstiyId));;
        }

        public IResult Update(University university)
        {
            return new SuccessResult();
            _universityDal.Update(university);
        }
    }
}
