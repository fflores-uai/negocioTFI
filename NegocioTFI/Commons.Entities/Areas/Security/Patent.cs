using System;

namespace Commons.Entities.Areas.Security
{
    public class Patent : FamilyElement
    {
        public override void Add(FamilyElement t)
        {
            throw new Exception("Action ADD Not Allowed");
        }

        public override void Remove(FamilyElement t)
        {
            throw new Exception("Action ADD Not Allowed");
        }
    }
}