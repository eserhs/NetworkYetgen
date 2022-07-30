using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
          
            _userDal.Add(user);
            return new SuccessResult();

        }

        public IResult Delete(User user)
        {
            return new SuccessResult();
            _userDal.Delete(user);
        }

        public IDataResult<List<User>> Getall()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList());
        }

        public IDataResult<User> GetbyUserId(int UserId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=> u.Id == UserId));
        }

        public IResult Update(User user)
        {

           return new SuccessResult ();
            _userDal.Update(user);  
        }
    }
}
