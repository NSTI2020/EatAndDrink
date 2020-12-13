namespace EatAndDrink.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public UnitMeasure UnitMeasures { get; set; }



    }


}
