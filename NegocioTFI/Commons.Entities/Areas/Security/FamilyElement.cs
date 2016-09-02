using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities.Areas.Security
{
    //Component
    public abstract class FamilyElement : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public abstract void Add(FamilyElement t);
        public abstract void Remove(FamilyElement t);
    }
}
