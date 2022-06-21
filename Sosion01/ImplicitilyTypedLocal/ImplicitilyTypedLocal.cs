class ImplicitilyTypedLocal
{
    static void Main(String[] args)
    {
        var i = 5;
        var s = "hello";
        var d = 1.0;
        // i is an integer
        Console.WriteLine("i*i :" + i * i);
        //s is an string
        Console.WriteLine("s in upper case:" + s.ToUpper());
        //d is a double
        Console.WriteLine("type id d:" + d.GetType());
        Console.ReadLine();
    }
}
