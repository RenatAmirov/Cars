using Microsoft.EntityFrameworkCore;
using System.Linq;
using TestProject.Data.Entities;

namespace TestProject.Data
{

    public class SeedData {

        public static void SeedDatabase(CarDbContext context) {

            context.Database.Migrate();

            if (context.Areas.Count() == 0) {

                var a1 = new AreaEntity { Name = "Area1"};
                var a2 = new AreaEntity { Name = "Area2" };

                var g11 = new GarageEntity { Name = "Garage11", Area = a1 };
                var g12 = new GarageEntity { Name = "Garage12", Area = a1 };
                var g21 = new GarageEntity { Name = "Garage21", Area = a2 };
                var g22 = new GarageEntity { Name = "Garage22", Area = a2 };

                var c111 = new CarEntity { Title = "Car111", Garage = g11 };
                var c112 = new CarEntity { Title = "Car112", Garage = g11 };
                var c121 = new CarEntity { Title = "Car121", Garage = g12 };
                var c122 = new CarEntity { Title = "Car122", Garage = g12 };
                var c211 = new CarEntity { Title = "Car211", Garage = g21 };
                var c212 = new CarEntity { Title = "Car212", Garage = g21 };
                var c221 = new CarEntity { Title = "Car221", Garage = g22 };
                var c222 = new CarEntity { Title = "Car222", Garage = g22 };

                context.Cars.AddRange(c111, c112, c121, c122, c211, c212, c221, c222);

                context.SaveChanges();
            }
        }
    }
}
