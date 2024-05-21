namespace _21._05_Task1
{
    
    
        internal class Car
        {


            public string Mercedes;
            public string E350;
            public double CurrentFuel;
            public double FuelFor1Km;
            public double Millage;

            public Car(string brend, string model, double currentFuel, double fuelFor1Km)
            {
                Mercedes = brend;
                E350 = model;
                CurrentFuel = currentFuel;
                FuelFor1Km = fuelFor1Km;
                Millage = 89345;
            }

            public void Drive(int km)
            {
                double requiredFuel = km * FuelFor1Km;

                if (CurrentFuel >= requiredFuel)
                {
                    Millage += km;
                    CurrentFuel -= requiredFuel;
                    Console.WriteLine($"{km} have traveled kilometers. remaining fuel: {CurrentFuel} Litr.");
                }
                else
                {
                    Console.WriteLine("You don't have enough fuel! Try traveling less distance.");
                }
            }
        }

    }



