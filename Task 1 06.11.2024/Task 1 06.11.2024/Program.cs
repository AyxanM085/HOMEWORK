class Program
{
    static void Main(string[] args)
    {
        ProductService productService = new ProductService();


        productService.Create(new ProductCreateDto
        {
            Name = "Sample Product",
            CostPrice = 2000,
            SalePrice = 3000
        });


        ProductGetDto product = productService.Get(1);
        if (product != null)
        {
            Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Sale Price: {product.SalePrice}");
        }


        List<ProductGetDto> allProducts = productService.GetAll();
        foreach (var p in allProducts)
        {
            Console.WriteLine($"Product ID: {p.Id}, Name: {p.Name}, Sale Price: {p.SalePrice}");
        }

        productService.Delete(1);
    }
}