using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorGPS.Entities
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}
