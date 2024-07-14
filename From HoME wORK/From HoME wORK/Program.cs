

public class Program
    {
    private static ApplicationDbContext context;

    public static async Task Main(string[] args)
        {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "CarDatabase");
                

        

            var carService = new CarService(context);

            var cars = await carService.GetCarsAsync();

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Id} {car.BrandName} {car.ModelName} {car.MaxSpeed} {car.FuelTankCapacity} {car.Power} {car.DoorCount} Colors: {string.Join(", ", car.Colors)}");
            }
        }

    private class DbContextOptionsBuilder<T>
    {
        public DbContextOptionsBuilder()
        {
        }

        internal object UseInMemoryDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }
    }
}




