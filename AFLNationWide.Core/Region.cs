namespace AFLNationWide.Core
{
    public class Region
    {
        public System.Guid Region_ID { get; set; }
        public string Regions { get; set; }
        public System.Guid State_ID { get; set; }

        public virtual State State { get; set; }
    }
}