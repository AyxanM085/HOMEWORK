﻿public class Color
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<CarColor> CarColors { get; set; }
}
