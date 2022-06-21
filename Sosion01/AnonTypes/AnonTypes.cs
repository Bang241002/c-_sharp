class AnonTypes
{
    static void Main(String[] args)
    {
        var pl= new { Name = "A", Price = 3 };
        Console.WriteLine("Name = {0}\nPrice = {1}",
            pl.Name.ToLower(), pl.Price);
        Console.ReadLine();
    }
}