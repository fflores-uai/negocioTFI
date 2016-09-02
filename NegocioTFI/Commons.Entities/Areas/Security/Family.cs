using System.Collections.Generic;

namespace Commons.Entities.Areas.Security
{
    public class Family : FamilyElement
    {
        private List<FamilyElement> _access = new List<FamilyElement>();

        public override void Add(FamilyElement t)
        {
            _access.Add(t);
        }

        public override void Remove(FamilyElement t)
        {
            _access.Remove(t);
        }

        public List<FamilyElement> Acceess
        {
            get { return _access; }
            set { _access = value; }
        }
    }
}