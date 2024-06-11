public class ProductService
{
    private List<Product> products = new List<Product>();
    private int nextId = 1;

    public void Create(ProductCreateDto productCreateDto)
    {
        var product = new Product
        {
            Id = nextId++,
            Name = productCreateDto.Name,
            CostPrice = productCreateDto.CostPrice,
            SalePrice = productCreateDto.SalePrice
        };
        products.Add(product);
    }

    public ProductGetDto Get(int id)
    {
        var product = products.Find(p => p.Id == id);
        if (product != null)
        {
            return new ProductGetDto
            {
                Id = product.Id,
                Name = product.Name,
                SalePrice = product.SalePrice
            };
        }
        return null; 
    }

    public List<ProductGetDto> GetAll()
    {
        return products.ConvertAll(p => new ProductGetDto
        {
            Id = p.Id,
            Name = p.Name,
            SalePrice = p.SalePrice
        });
    }

    public void Delete(int id)
    {
        var index = products.FindIndex(p => p.Id == id);
        if (index != -1)
        {
            products.RemoveAt(index);
        }
        
    }
}
