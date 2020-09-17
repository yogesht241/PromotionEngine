using System;

public interface IProductService
{
    void GetPriceByType(Product product);
    int GetTotalPrice(List<Product> products);
}