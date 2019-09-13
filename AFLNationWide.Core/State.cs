using System.Collections.Generic;

namespace AFLNationWide.Core
{
    public class State
    {
        public System.Guid State_ID { get; set; }
        public string State_Name { get; set; }
        public virtual ICollection<Region> Regions { get; set; }

    }
}