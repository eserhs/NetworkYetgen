using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class City:IEntity
    {
        public int Id { get; set; }
        public String CityName { get; set; }
        public String CoyntryName { get; set; }
    }
}
