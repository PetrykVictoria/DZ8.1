interface IPriceable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizeable
{
    void SetSize(byte size);
}

class Book : IPriceable, IDiscountable
{
    private double price;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        // Логіка застосування знижки для книг
    }
}

class UpperClothing : IPriceable, IDiscountable, IColorable, ISizeable
{
    private double price;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyDiscount(string discount)
    {
        // Логіка застосування знижки для верхнього одягу
    }

    public void SetColor(byte color)
    {
        this.color = color;
    }

    public void SetSize(byte size)
    {
        this.size = size;
    }
}
