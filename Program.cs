using IoC;

BL bl = new BL();

bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}");
});