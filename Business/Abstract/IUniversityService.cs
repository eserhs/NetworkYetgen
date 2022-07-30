using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUniversityService
    {
        IResult Add(University university);
        IResult Delete(University university);  
        IResult Update(University university);  

        IDataResult<List<University>> GetAll();
        IDataResult<University> GetByUniversityId(int UniverstiyId);
    }
}
