using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
