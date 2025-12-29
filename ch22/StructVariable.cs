using System;

class StructVariable
{
    static void Main()
    {
        Product product;

        product.Id = 1;
        product.Title = "좋은 책";
        product.Price = 10_000m;

        string message = $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";
        Console.WriteLine(message);
    }
}

struct Product
{
    public int Id;
    public string Title;
    public decimal Price;
}