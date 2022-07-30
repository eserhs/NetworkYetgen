using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int Id { get; set; }
        public int UserId  { get; set; }
        public int ImageId { get; set; }
        public int CityId { get; set; }
        public int UniversityId { get; set; }
        public String Gender { get; set; }
        public DateTime Age { get; set; }
        public String About{ get; set; }
    }
}
