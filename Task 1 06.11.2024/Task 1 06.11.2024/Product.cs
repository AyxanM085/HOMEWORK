using System;
using System.Collections.Generic;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CostPrice { get; set; } = 1500; 
    public decimal SalePrice { get; set; } = 2500; 
}


public class ProductGetDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal SalePrice { get; set; }
}

public class ProductCreateDto
{
    public string Name { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
}