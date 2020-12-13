namespace EatAndDrink.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Attribute Attribute { get; set; }

    }
}
