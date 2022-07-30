using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICityService
    {
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);

        IDataResult<List<City>> GetAll();
        IDataResult<City> GetByCityId(int CityID);

    }
}
