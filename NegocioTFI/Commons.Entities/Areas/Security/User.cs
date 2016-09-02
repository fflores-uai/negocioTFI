using System.Collections.Generic;

namespace Commons.Entities.Areas.Security
{
    public class User
    {
        public int ID { get; set; }
        public string NetworkID { get; set; }
        public string Password { get; set; }

        private List<FamilyElement> _permissions = new List<FamilyElement>();

        public List<FamilyElement> Permissions
        {
            get { return _permissions; }
            set { _permissions = value; }
        }
    }
}