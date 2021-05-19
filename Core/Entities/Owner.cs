namespace Core.Entities
{
    public class Owner : BaseEntity
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string ImgPath { get; set; }
        public Address OwnerAddress { get; set; }
    }

}
