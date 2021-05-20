namespace Core.Entities
{
    public class Address : BaseEntity
    {
        public string Country { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

    }

}
