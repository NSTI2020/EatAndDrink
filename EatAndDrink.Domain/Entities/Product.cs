namespace EatAndDrink.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PricePaid { get; set; }
        public int UnitMeasuresId { get; set; }
        public UnitMeasure UnitMeasures { get; set; }
        public int Quantity { get; set; }
        public string MeasureTxt { get; set; }
        
    }


}
