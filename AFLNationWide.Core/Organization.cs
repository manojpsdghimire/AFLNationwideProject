namespace AFLNationWide.Core
{
    class Organization
    {
        public System.Guid Organization_ID { get; set; }
        public string Organization_Name { get; set; }
        public System.Guid AddressID { get; set; }

        public virtual Address Address { get; set; }
    }
}
