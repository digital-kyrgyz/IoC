using IoC;

BL bl = new BL(new DAL());

bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}");
});