using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPersonService
    {
        IResult Add(Person person); 
        IResult Delete(Person person);  
        IResult Update(Person person);

        IDataResult<List<Person>> GetAll();
        IDataResult<Person>GetByUserId(int UserId);
        IDataResult<Person> GetByImageId(int ImageId);
        IDataResult<Person> GetByCityId(int CityId);
        IDataResult<Person> GetByUniversityId(int  UniversityId);
        



    }
}
