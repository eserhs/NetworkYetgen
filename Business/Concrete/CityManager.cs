using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            return new SuccessResult();
                _cityDal.Add(city);

        }

        public IResult Delete(City city)
        {
            return new SuccessResult(); 
            _cityDal.Delete(city);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetList());
        }

        public IDataResult<City> GetByCityId(int CityID)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.Id == CityID));
        }

        public IResult Update(City city)
        {
            return new SuccessResult();
            _cityDal.Update(city);
        }
    }
}
