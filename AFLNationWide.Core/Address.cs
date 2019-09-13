using System.Collections.Generic;

namespace AFLNationWide.Core
{
    class Address
    {
        public System.Guid AddressID { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public System.Guid State_ID { get; set; }
        public System.Guid Country_ID { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
