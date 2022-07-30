using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult Add(Person person)
        {
            return new SuccessResult();
            _personDal.Add(person);
        }

        public IResult Delete(Person person)
        {

            return new SuccessResult();
            _personDal.Delete(person);
        }

        public IDataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetList());
        }

        public IDataResult<Person> GetByCityId(int CityId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.CityId == CityId)) ;
        }

        public IDataResult<Person> GetByImageId(int ImageId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.ImageId == ImageId));
        }

        public IDataResult<Person> GetByUniversityId(int UniversityId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.UniversityId == UniversityId));
        }

        public IDataResult<Person> GetByUserId(int UserId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.UserId == UserId));
        }

        public IResult Update(Person person)
        {

            return new SuccessResult();
            _personDal.Update(person);
        }
    }
}
