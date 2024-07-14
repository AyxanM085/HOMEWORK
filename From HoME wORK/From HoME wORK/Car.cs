using System;
using System.Reflection;

namespace From_HoME_wORK
{
	public class Car
	{
        public int Id { get; set; }
        public int MaxSpeed { get; set; }
        public int FuelTankCapacity { get; set; }
        public string Power { get; set; }
        public int DoorCount { get; set; }

        public int ModelId { get; set; }
        public Module Model { get; set; }

        public ICollection<Car_Color> CarColors { get; set; }

    }
}

