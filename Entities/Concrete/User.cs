using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class User:IEntity
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String UserLastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

    }
}
