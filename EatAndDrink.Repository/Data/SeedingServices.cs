using System.Linq;
using EatAndDrink.Domain.Entities;
using EatAndDrink.Repository.Data;
namespace EatAndDrink.Repository.Data
{

    public class SeedingServices
    {

        private readonly EDContext _context;
        public SeedingServices()
        {


        }
        public SeedingServices(EDContext context)
        {
            _context = context;

        }
        public bool Seed()
        {
            UnitMeasure Kg1 = new UnitMeasure();
            Kg1.Id = 1;
            Kg1.Unit = "KG";

            UnitMeasure Kg2 = new UnitMeasure();
            Kg2.Id = 2;
            Kg2.Unit = "G";

            UnitMeasure Kg3 = new UnitMeasure();
            Kg3.Id = 3;
            Kg3.Unit = "L";

            UnitMeasure Kg4 = new UnitMeasure();
            Kg4.Id = 4;
            Kg4.Unit = "ML";

            SubCategory s1 = new SubCategory();
            s1.Id = 1;
            s1.Name = "Sem Álcool";

            Category c1 = new Category();
            c1.Id = 1;
            c1.Name = "Bebidas";
            c1.SubCategory = s1;

            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Água Mineral";
            p1.UnitMeasures = Kg1;
            p1.Quantity = 150;
            p1.Description = "Fonte do posto do maluco";
            p1.Category = c1;
            p1.Price = 0350;


            _context.Add(Kg1);
            _context.Add(Kg2);
            _context.Add(Kg3);
            _context.Add(Kg4);
            _context.Add(s1);
            _context.Add(c1);
            _context.Add(p1);



            if (_context.UnitMeasures.Any()
                && _context.SubCategories.Any()
                && _context.Products.Any()
                && _context.Categories.Any())
            {
                return false;
            }

            if (_context.SaveChanges() > 0)
            {
                return true;
            }



            return false;
        }

    }


}
