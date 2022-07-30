using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class University:IEntity
    {
        public int Id { get; set; }
        public String UniversityName { get; set; }
        public String IsAcive { get; set; }
        public DateTime DateTime { get; set; }
    }
}
